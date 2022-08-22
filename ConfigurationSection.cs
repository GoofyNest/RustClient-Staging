public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
	// Methods

	// RVA: 0x2321CE0 Offset: 0x23202E0 VA: 0x182321CE0 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x2321D10 Offset: 0x2320310 VA: 0x182321D10 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x2321D40 Offset: 0x2320340 VA: 0x182321D40 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x2321D70 Offset: 0x2320370 VA: 0x182321D70 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

