internal sealed class VisualTreeUpdater // TypeDefIndex: 4621
{
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; 


	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4622
{
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; 

	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }


	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	public IVisualTreeUpdater get_Item(int index) { }

}

