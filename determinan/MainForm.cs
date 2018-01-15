/*
 * Created by SharpDevelop.
 * User: Meysam
 * Date: 1/7/2018
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace determinan
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonResultClick(object sender, EventArgs e)
		{
			if (mat11.Text != "" &&
			    mat12.Text != "" &&
			    mat13.Text != "" &&
			    mat21.Text != "" &&
			    mat22.Text != "" &&
			    mat23.Text != "" &&
			    mat31.Text != "" &&
			    mat32.Text != "" &&
			    mat33.Text != ""
			   )
			{
				try
				{
					int det = 
						+ Convert.ToInt32(mat11.Text) * 
						((Convert.ToInt32(mat22.Text) * Convert.ToInt32(mat33.Text))
						 - (Convert.ToInt32(mat32.Text) * Convert.ToInt32(mat23.Text)))
						
						- Convert.ToInt32(mat12.Text) * 
						((Convert.ToInt32(mat21.Text) * Convert.ToInt32(mat33.Text))
						 - (Convert.ToInt32(mat31.Text) * Convert.ToInt32(mat23.Text)))
						
						+ Convert.ToInt32(mat13.Text) * 
						((Convert.ToInt32(mat21.Text) * Convert.ToInt32(mat32.Text))
						 - (Convert.ToInt32(mat31.Text) * Convert.ToInt32(mat22.Text)));
					labelResult.Text = Convert.ToString(det);
						
				}
				catch(Exception)
				{
					labelResult.Text = "Enter integers!";
				}
				
			}
			
			else
				labelResult.Text = "Enter numbers!";
		}
	}
}
