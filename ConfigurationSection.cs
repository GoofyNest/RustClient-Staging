public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
	// Methods

	// RVA: 0x2321BE0 Offset: 0x23201E0 VA: 0x182321BE0 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x2321C10 Offset: 0x2320210 VA: 0x182321C10 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x2321C40 Offset: 0x2320240 VA: 0x182321C40 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x2321C70 Offset: 0x2320270 VA: 0x182321C70 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

