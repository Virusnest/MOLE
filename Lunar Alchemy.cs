using System;
using System.IO;
using System.Collections.Generic;

namespace LA
{
	public class Lunar_Alchemy 
	{
		public static void Main(string[] args)
		{

			/*ROMHandler rh = new ROMHandler(String.Format("../../ROMs/Clean/{0}",args[0]));

			Console.WriteLine("Testing HexWrite() and Undo-Redo system");
			Console.WriteLine("Initial Value of first 8 bytes: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.HexWrite("0123456789ABCDEF", 0);

			Console.WriteLine("HexWrite() modified 8 bytes: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.UR.Undo();

			Console.WriteLine("Undo: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.UR.Redo();

			Console.WriteLine("Redo: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.HexWrite("89ABCDEF", 0);

			Console.WriteLine("HexWrite modified 4 bytes: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.UR.Undo();

			Console.WriteLine("Undo: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			rh.UR.Undo();

			Console.WriteLine("Undo: ");
			Console.WriteLine(Utils.ByteArrToHexStr(rh.ROM, 8, 0));

			Console.WriteLine("HexWrite() modified 4 bytes: ");
			rh.HexWrite("89ABCDEF", 0);

			Console.WriteLine("Saving as {0} ... ", rh.ROMName + "_TEST.smc");
			rh.Save();
			*/

			//GFXHandler gh = new GFXHandler(String.Format("../../ROMs/Clean/{0}", args[0]));

			//web.Downloader.GetAsarBuild(web.Downloader.PresetAppveyorRequest.latestSuccess);
			//web.Downloader.GetAsarLatestRelease();

			AsarCLR.Asar.init();
			var input = 0x088000;
			var pc = AsarCLR.AsarExt.SnesToPc(input);
			var snes = AsarCLR.AsarExt.PcToSnes(pc);
			Console.WriteLine("0x{0:X}", input);
			Console.WriteLine("0x{0:X}", pc);
			Console.WriteLine("0x{0:X}", snes);


			Console.ReadKey();
		}
	}
}