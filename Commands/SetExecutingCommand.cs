using System;
using System.Linq;
using System.Globalization;
using System.Collections;

namespace ExtPlaneNet.Commands
{
	public class SetExecutingCommand : Command
	{
		public string DataRef { get; set; }

		public SetExecutingCommand(string dataRef, CommandType type) : base("cmd ")
		{
			if (string.IsNullOrWhiteSpace(dataRef))
				throw new ArgumentNullException("dataRef");

			DataRef = dataRef;
            Name += Enum.GetName(typeof(CommandType), type)?.ToLower();
		}

		protected override string FormatParameters()
		{
		    return DataRef;
		}
	}
}