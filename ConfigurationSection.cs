public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
{
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1693
	// Methods

	// RVA: 0x2321A20 Offset: 0x2320020 VA: 0x182321A20 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x2321A50 Offset: 0x2320050 VA: 0x182321A50 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x2321A80 Offset: 0x2320080 VA: 0x182321A80 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x2321AB0 Offset: 0x23200B0 VA: 0x182321AB0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

