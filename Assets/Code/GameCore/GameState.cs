#region Copyright
//-----------------------------------------------------------------------
// <copyright file="GameState.cs" company="Megalodon Softwares">
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

	#endregion
	/// <summary>Todo: Add GameState description</summary>
	public abstract class GameState {
		#region Fields
		/* Sample variable, may be an owner
		protected Character character;
		*/
		#endregion
		#region Constructors
		/* Sample constructor setting variable
		public State(Character character) {
			this.character = character;
		}
		*/
		#endregion
		#region Methods
		public abstract void Tick();
		public virtual void OnStateEnter() { }
		public virtual void OnStateExit() { }
		
		#endregion
		#region Helpers
		#endregion
		#region Properties
		#endregion
	}
}
