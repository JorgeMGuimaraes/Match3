#region Copyright
//-----------------------------------------------------------------------
// <copyright file="BaseButton.cs" company="Megalodon Softwares">
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
	using UnityEngine;

	#endregion
	/// <summary>Todo: Add BaseButton description</summary>
	public class BaseButton : MonoBehaviour {
		#region Fields
		#endregion
		#region Constructors
		#endregion
		#region Methods
		internal virtual void Start() {
			Button	= GetComponent<UnityEngine.UI.Button>();
			Text	= GetComponentInChildren<UnityEngine.UI.Text>();
			Button.onClick.AddListener(BtnAction);
		}

		#endregion
		#region Helpers
		internal virtual void BtnAction() {
		}
		#endregion
		#region Properties
		internal UnityEngine.UI.Button Button { get; set; }
		internal UnityEngine.UI.Text Text { get; set; }
		#endregion
	}
}
