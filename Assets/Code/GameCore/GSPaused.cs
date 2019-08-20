#region Copyright
//-----------------------------------------------------------------------
// <copyright file="GSPaused.cs" company="Megalodon Softwares">
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
	/// <summary>Todo: Add GSPaused description</summary>
	public class GSPaused : GameState {
		#region Fields
		private GameObject pauseMenu, gameHUD;
		#endregion
		#region Constructors
		#endregion
		#region Methods
		public override string ToString() => "Game Paused";
		public override void Tick() {
			CheckPauseInput();
		}
		public override void OnStateEnter() {
			GetMenusRefs();
			ShowPauseMenu(true);
		}

		public override void OnStateExit() {
			ShowPauseMenu(false);
		}

		#endregion
		#region Helpers
		private void GetMenusRefs() {
			gameHUD		= GameObject.Find("GUIManagerCanvas");
			pauseMenu	= GameObject.Instantiate(GameManager.instance.pauseMenu);
		}
		private void ShowPauseMenu(bool paused) {
			gameHUD.SetActive(!paused);
			pauseMenu.SetActive(paused);

		}
		private void CheckPauseInput() {
			if (Input.GetKeyDown(KeyCode.Escape)) { GameManager.instance.SetGameState(new GSPaused()); }
		}
		#endregion
		#region Properties
		public bool IsPlaying { get; } = false;

		#endregion
	}
}
