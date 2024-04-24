using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO; // For Directory




namespace Dir
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button dirBtn;
		private System.Windows.Forms.Button sysdirBtn;
		private System.Windows.Forms.Button envBtn;
		private System.Windows.Forms.Button sysinfBtn;
		private System.Windows.Forms.Button pathBtn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dirBtn = new System.Windows.Forms.Button();
            this.sysdirBtn = new System.Windows.Forms.Button();
            this.envBtn = new System.Windows.Forms.Button();
            this.sysinfBtn = new System.Windows.Forms.Button();
            this.pathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(758, 258);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dirBtn
            // 
            this.dirBtn.Location = new System.Drawing.Point(67, 323);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(154, 27);
            this.dirBtn.TabIndex = 1;
            this.dirBtn.Text = "Directory Test";
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // sysdirBtn
            // 
            this.sysdirBtn.Location = new System.Drawing.Point(67, 360);
            this.sysdirBtn.Name = "sysdirBtn";
            this.sysdirBtn.Size = new System.Drawing.Size(154, 27);
            this.sysdirBtn.TabIndex = 2;
            this.sysdirBtn.Text = "File in System Dir";
            this.sysdirBtn.Click += new System.EventHandler(this.sysdirBtn_Click);
            // 
            // envBtn
            // 
            this.envBtn.Location = new System.Drawing.Point(67, 397);
            this.envBtn.Name = "envBtn";
            this.envBtn.Size = new System.Drawing.Size(154, 26);
            this.envBtn.TabIndex = 3;
            this.envBtn.Text = "Environment Test";
            this.envBtn.Click += new System.EventHandler(this.envBtn_Click);
            // 
            // sysinfBtn
            // 
            this.sysinfBtn.Location = new System.Drawing.Point(67, 434);
            this.sysinfBtn.Name = "sysinfBtn";
            this.sysinfBtn.Size = new System.Drawing.Size(154, 26);
            this.sysinfBtn.TabIndex = 4;
            this.sysinfBtn.Text = "System Information";
            this.sysinfBtn.Click += new System.EventHandler(this.sysinfBtn_Click);
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(67, 471);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(154, 26);
            this.pathBtn.TabIndex = 5;
            this.pathBtn.Text = "Path Test";
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(896, 520);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.sysinfBtn);
            this.Controls.Add(this.envBtn);
            this.Controls.Add(this.sysdirBtn);
            this.Controls.Add(this.dirBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void dirBtn_Click(object sender, System.EventArgs e)
		{
			richTextBox1.Clear();
			// Drives
			try 
			{
				string[] drives = Directory.GetLogicalDrives();
				foreach (string drive in drives) 
				{
					richTextBox1.AppendText(drive+"\n");
				}
			}
			catch (Exception ex) 
			{
				richTextBox1.AppendText(ex.Message+"\n");
			}

			// Current Directory
			string currdir = Directory.GetCurrentDirectory();
			richTextBox1.AppendText("GetCurrentDirectory() = " + currdir + "\n");

			// Root (top-level) directory
			string dirroot = Directory.GetDirectoryRoot(currdir);
			richTextBox1.AppendText("GetDirectoryRoot() = " + dirroot + "\n");
						
			// SubDirectories
			string [] subdirs = Directory.GetDirectories(dirroot);
			foreach(string sd in subdirs)
				richTextBox1.AppendText(sd+"\n");

			// Program Files Dir
			string pfdir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			richTextBox1.AppendText("Program Files Dir = " + pfdir + "\n");

			// System Dir
			string sysdir = Environment.SystemDirectory;
			richTextBox1.AppendText("System Dir = " + sysdir + "\n");

		
			
		}

		private void sysdirBtn_Click(object sender, System.EventArgs e)
		{
			// Files in System Dir
			richTextBox1.Clear();
			string [] files = Directory.GetFiles(Environment.SystemDirectory);
			richTextBox1.AppendText("Files in System Directory");
			foreach(string fn in files)
				richTextBox1.AppendText(fn + "\n");
		
		}

		private void envBtn_Click(object sender, System.EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox1.AppendText("Cookies Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.Cookies)+"\n");
			richTextBox1.AppendText("StartMenu Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)+"\n");
			richTextBox1.AppendText("Machine Name = " + Environment.MachineName+"\n");
			richTextBox1.AppendText("User Name = " + Environment.UserName+"\n");
			richTextBox1.AppendText("CLR Version = " + Environment.Version+"\n");
		
			// SubDirectories
			richTextBox1.AppendText("Files in Program Files folder:\n");
			string [] subdirs = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			foreach(string sd in subdirs)
				richTextBox1.AppendText(sd+"\n");

			// OS
			OperatingSystem osver = Environment.OSVersion;
			richTextBox1.AppendText("OS Version = " + osver +"\n");
			richTextBox1.AppendText("OS Platform and Version = " + osver.Platform + ":" +osver.Version +"\n");

			
			// Get all environment variables
			IDictionary envvars = Environment.GetEnvironmentVariables();
			foreach( DictionaryEntry de in envvars )
				richTextBox1.AppendText(de.Key + " = " + de.Value + "\n");

			// Get a specific variable
			string homedrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
			if (homedrive == null) homedrive = "Error: Environment Variable not found.";
			richTextBox1.AppendText("HOMEDRIVE=[" +homedrive+ "]\n");

			// Dealing with non existent variables
			string gribbit = Environment.GetEnvironmentVariable("GRIBBIT");
			if (gribbit == null ) gribbit = "Error: Environment Variable not found.";
			richTextBox1.AppendText("GRIBBIT=[" +gribbit+ "]\n");

		}

		private void sysinfBtn_Click(object sender, System.EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox1.AppendText("Boot Mode = " + SystemInformation.BootMode+"\n");
			richTextBox1.AppendText("Icon Size = " + SystemInformation.IconSize+"\n");
			richTextBox1.AppendText("Small Icon Size = " + SystemInformation.SmallIconSize+"\n");
			richTextBox1.AppendText("Menu Font = " + SystemInformation.MenuFont+"\n");
			richTextBox1.AppendText("Network = " + SystemInformation.Network+"\n");
			richTextBox1.AppendText("Working Area = " + SystemInformation.WorkingArea+"\n");
			

		}

		private void pathBtn_Click(object sender, System.EventArgs e)
		{
			string path = Application.ExecutablePath;
			richTextBox1.Clear();
			richTextBox1.AppendText("Application.ExecutablePath=" + path +"\n");			
			richTextBox1.AppendText("Path.GetDirectoryName=" + Path.GetDirectoryName(path) +"\n");
			richTextBox1.AppendText("Path.GetExtension=" + Path.GetExtension(path) +"\n");
			richTextBox1.AppendText("Path.GetFileName= "+ Path.GetFileName(path) +"\n");
			richTextBox1.AppendText("Path.GetFileNameWithoutExtension=" + Path.GetFileNameWithoutExtension(path) +"\n");
			richTextBox1.AppendText("Path.GetPathRoot=" + Path.GetPathRoot(path) +"\n");

		}

		
		}
	}

