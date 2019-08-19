#region Copyright
//-----------------------------------------------------------------------
// <copyright file="GSExitGame.cs" company="Megalodon Softwares">
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// </copyright>
//-----------------------------------------------------------------------
#endregion
namespace Assets.Code.GameCore {
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using System.Threading.Tasks;

	#endregion
	/// <summary>Todo: Add GSExitGame description</summary>
	public class GSExitGame : GameState {
		#region Fields
		#endregion
		#region Constructors
		#endregion
		#region Methods
		public override string ToString() => "Exit Game";
		public override void Tick() {

		}
		public override void OnStateEnter() => ExitGame();

		public override void OnStateExit() => base.OnStateExit();

		#endregion
		#region Helpers
		public void ExitGame() {
#if UNITY_STANDALONE											// If we are running in a standalone build of the game			
			Application.Quit();									// Quit the application
#endif			
#if UNITY_EDITOR												// If we are running in the editor			
			UnityEditor.EditorApplication.isPlaying = false;	// Stop playing the scene
#endif
		}

		#endregion
		#region Properties
		#endregion
	}
}
