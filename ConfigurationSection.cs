public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
	// Methods

	// RVA: 0x2322500 Offset: 0x2320B00 VA: 0x182322500 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x2322530 Offset: 0x2320B30 VA: 0x182322530 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x2322560 Offset: 0x2320B60 VA: 0x182322560 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x2322590 Offset: 0x2320B90 VA: 0x182322590 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

