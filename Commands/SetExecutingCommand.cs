using System;
using System.Linq;
using System.Globalization;
using System.Collections;

namespace ExtPlaneNet.Commands
{
	public class SetExecutingCommand : Command
	{
		public string DataRef { get; set; }

		public SetExecutingCommand(string dataRef) : base("cmd once")
		{
			if (string.IsNullOrWhiteSpace(dataRef))
				throw new ArgumentNullException("dataRef");

			DataRef = dataRef;
		}

		protected override string FormatParameters()
		{
		    return DataRef;
		}
	}
}