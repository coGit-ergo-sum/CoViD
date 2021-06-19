﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Decimal;
using System.Drawing;

namespace CoViD.GUI.Tools.Extensions.Profile
{
	/// <summary>
	/// Collection of extension specific for this project.
	/// </summary>
	public static class Methods
	{
		/// <summary>
		/// Reads the settings for the CoViD simulation.
		/// </summary>
		/// <param name="profile">The class Profile extended by this extension method.</param>
		/// <param name="section">The section of the INI file.</param>
		/// <param name="key">The Key of the INI file.</param>
		/// <param name="default">The default values to return it is not possible read the INI (for any reason).</param>
		/// <returns>The values in the INI files. Default if any issue raises.</returns>
		public static CoViD.CovidSettings Read(this Vi.Tools.Profile profile, string section, string key, CoViD.CovidSettings @default)
		{
			@default.Radius = profile.Read(section, key + ".Radius", string.Empty).ToDecimal(@default.Radius);
			@default.People = profile.Read(section, key + ".People", @default.People);
			@default.Steps = profile.Read(section, key + ".Steps", string.Empty).ToByte(@default.Steps);
			@default.Ticks = profile.Read(section, key + ".Ticks", @default.Ticks);
			@default.Segregation = profile.Read(section, key + ".Segregation", string.Empty).ToPercentage(@default.Segregation);

			////////////@default.Radius = Program.profile.Read(section, key + ".Radius", string.Empty).ToDecimal(@default.Radius);
			////////////@default.People = Program.profile.Read(section, key + ".People", @default.People);
			////////////@default.Steps = Program.profile.Read(section, key + ".Steps", string.Empty).ToByte(@default.Steps);
			////////////@default.Ticks = Program.profile.Read(section, key + ".Ticks", @default.Ticks);
			////////////@default.Segregation = Program.profile.Read(section, key + ".Segregation", string.Empty).ToPercentage(@default.Segregation);

			return @default;
		}

		/// <summary>
		/// Writes the settings for the CoViD simulation.
		/// </summary>
		/// <param name="profile">The class Profile extended by this extension method.</param>
		/// <param name="section">The section of the INI file.</param>
		/// <param name="key">The Key of the INI file.</param>
		/// <param name="settings">The set of values to store in the INI file.</param>
		public static void Write(this Vi.Tools.Profile profile, string section, string key, CoViD.CovidSettings settings)
		{
			profile.Write(section, key + ".Radius", settings.Radius);
			profile.Write(section, key + ".People", settings.People);
			profile.Write(section, key + ".Steps", settings.Steps);
			profile.Write(section, key + ".Ticks", settings.Ticks);
			profile.Write(section, key + ".Segregation", settings.Segregation);

		}
	}
}

