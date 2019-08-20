#region Copyright
//-----------------------------------------------------------------------
// <copyright file="GSPlaying.cs" company="Megalodon Softwares">
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// </copyright>
//-----------------------------------------------------------------------
#endregion
namespace Assets.Code.GameCore {
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using UnityEngine;

	#endregion
	/// <summary>Todo: Add GSPlaying description</summary>
	public class GSPlaying : GameState {
		#region Fields
		#endregion
		#region Constructors
		#endregion
		#region Methods
		public override string ToString() => "Playing Game";
		public override void Tick() {
			CheckPauseInput();
		}
		public override void OnStateEnter() {
			StartGame();
		}
		public override void OnStateExit() {
		}
		#endregion
		#region Helpers
		private void StartGame() {
			//GameManager.instance.LoadScene("Game");
		}
		private void CheckPauseInput() {
			if (Input.GetKeyDown(KeyCode.Escape)) { GameManager.instance.SetGameState(new GSPaused()); }

		}
		#endregion
		#region Properties
		public bool IsPlaying { get; } = true;
		#endregion
	}
}
