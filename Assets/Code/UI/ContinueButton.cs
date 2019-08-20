#region Copyright
//-----------------------------------------------------------------------
// <copyright file="ContinueButton.cs" company="Megalodon Softwares">
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// </copyright>
//-----------------------------------------------------------------------
#endregion
namespace Assets.Code.UI {
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Assets.Code.GameCore;

	#endregion
	/// <summary>Todo: Add ContinueButton description</summary>
	public class ContinueButton : BaseButton {
		#region Fields
		#endregion
		#region Constructors
		#endregion
		#region Methods
		#endregion
		#region Helpers
		internal override void BtnAction() => GameManager.instance.SetGameState(new GSPlaying());
		#endregion
		#region Properties
		#endregion
	}
}
