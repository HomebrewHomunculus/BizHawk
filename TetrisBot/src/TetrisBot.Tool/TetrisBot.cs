using System;
using System.Drawing;
using System.Windows.Forms;

using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;

//using BizHawk.Emulation.Common;


namespace TetrisBot
{
	[ExternalTool("TetrisBot")]
	public sealed class TetrisBotForm : ToolFormBase, IExternalToolForm
	{
		protected override string WindowTitleStatic // required when superclass is ToolFormBase
			=> "A bot for tetrissss";

		private readonly Label lblLoadedGame = new() { AutoSize = true };


		public TetrisBotForm()
		{
			ClientSize = new Size(480, 320);
			SuspendLayout();
			Controls.Add(new Label { AutoSize = true, Text = "Hello, world!" });
			Controls.Add(lblLoadedGame);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}



		public ApiContainer? _maybeAPIContainer { get; set; }

		private ApiContainer APIs
			=> _maybeAPIContainer!;


		public override void Restart()
		{
			Log("Restart()");
			//lblLoadedGame.Text = APIs.EmuClient.Game.Name();
			var gamename = APIs.Emulation.GetGameInfo().Name;
			lblLoadedGame.Text = gamename;
			Log($"GAME NAME: {gamename}");
		}


        protected override void UpdateAfter()
        {
			//Log("UpdateAfter()");
        	// executed after every frame (except while turboing, use FastUpdateAfter for that)
        }

        protected override void FastUpdateAfter()
        {
			//Log("FastUpdateAfter() TURBO! ");
        }

        private void Log(String msg)
        {
        	Console.WriteLine("[TetrisBot] " + msg);
        }


	}
}