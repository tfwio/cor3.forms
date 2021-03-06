﻿/*
 * Created by SharpDevelop.
 * User: tfw
 * Date: 8/12/2009
 * Time: 3:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace System.Cor3.Forms
{
	public class TimedTextBoxAssertion : Component
	{
		IComponent statusMain = null;
		public TextBox TextControl {
			get { return (TextBox) statusMain; }
			set { statusMain = value; }
		}
		TextBox SetTextBoxText(IComponent c) {
			statusMain = c;
			return (TextBox)statusMain;
		}
		bool HasNoControl { get { return (statusMain==null); } }
	
		private Timer statTimer = new Timer();
	
		bool Ticking { get { return statTimer.Enabled; } set { statTimer.Enabled = value; } }
		string lastStatus = string.Empty;
		
		public string StatusMain { get { if (HasNoControl) return null; return TextControl.Text; } set { TextControl.Text = value; } }
		public string FlashStatus { set { if (HasNoControl) return; StartStatus(value); } }
	
		public int TimerInterval
		{
			get { return statTimer.Interval; }
			set { statTimer.Interval = value; }
		}
	
		void StartStatus(string value)
		{
			if (Ticking) { statTimer.Stop(); StatusMain = value; statTimer.Start(); }
			else { lastStatus = StatusMain; StatusMain = value; statTimer.Start(); }
		}
		void eTick (object s, EventArgs e) { statTimer.Stop(); StatusMain = lastStatus; }
	
		public TimedTextBoxAssertion()
		{
			statTimer.Interval = 1800;
			statTimer.Tick += eTick;
		}
	}
}
