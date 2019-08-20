#region Copyright
//-----------------------------------------------------------------------
// <copyright file="MenuButton.cs" company="Megalodon Softwares">
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
	/// <summary>Todo: Add MenuButton description</summary>
	public class MenuButton : BaseButton {
		#region Fields
		#endregion
		#region Constructors
		#endregion
		#region Methods
		#endregion
		#region Helpers
		internal override void BtnAction() => GameManager.instance.SetGameState(new GSMainMenu());
		#endregion
		#region Properties
		#endregion
	}
}
