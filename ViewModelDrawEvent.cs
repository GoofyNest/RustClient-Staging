public struct ViewModelDrawEvent : IEquatable<ViewModelDrawEvent> // TypeDefIndex: 11476
{
	public ViewModelRenderer viewModelRenderer; 
	public Renderer renderer; 
	public bool skipDepthPrePass; 
	public Material material; 
	public int subMesh; 
	public int pass; 


	public bool Equals(ViewModelDrawEvent other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

