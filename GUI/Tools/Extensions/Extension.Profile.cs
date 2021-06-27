
using Vi.Tools.Extensions.String;

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
		/// <param name="default">The default values to return it is not possible read the INI (for any reason).</param>
		/// <returns>The values in the INI files. Default if any issue raises.</returns>
		public static CoViD.INI Read(this Vi.Tools.Profile profile, CoViD.INI @default)
		{
			@default.Radius = profile.Read("Settings", "Radius", string.Empty).ToDecimal(@default.Radius);
			@default.People = profile.Read("Settings", "People", @default.People);
			@default.Steps = profile.Read("Settings", "Steps", string.Empty).ToByte(@default.Steps);
			@default.Ticks = profile.Read("Settings", "Ticks", @default.Ticks);
			@default.Isolation = profile.Read("Settings", "Isolation", string.Empty).ToPercentage(@default.Isolation);

			return @default;
		}

		/// <summary>
		/// Writes the settings for the CoViD simulation.
		/// </summary>
		/// <param name="profile">The class Profile extended by this extension method.</param>
		/// <param name="settings">The set of values to store in the INI file.</param>
		public static void Write(this Vi.Tools.Profile profile, CoViD.INI settings)
		{
			profile.Write("Settings", "Radius", settings.Radius);
			profile.Write("Settings", "People", settings.People);
			profile.Write("Settings", "Steps", settings.Steps);
			profile.Write("Settings", "Ticks", settings.Ticks);
			profile.Write("Settings", "Isolation", settings.Isolation);

		}
	}
}

