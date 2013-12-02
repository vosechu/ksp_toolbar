﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toolbar {
	/// <summary>
	/// Determines visibility of a button.
	/// </summary>
	public interface IVisibility {
		/// <summary>
		/// Whether a button is currently visible or not.
		/// </summary>
		/// <seealso cref="IButton.Visibility"/>
		/// <seealso cref="IButton.Visible"/>
		bool Visible {
			get;
		}
	}
}