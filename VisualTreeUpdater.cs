internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	// Fields
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0x22F7810 Offset: 0x22F5E10 VA: 0x1822F7810
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x22F76E0 Offset: 0x22F5CE0 VA: 0x1822F76E0
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public IVisualTreeUpdater get_Item(int index) { }

}

