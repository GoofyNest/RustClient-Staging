public class MeshRendererLookup // TypeDefIndex: 10888
{
	public MeshRendererLookup.LookupGroup src; 
	public MeshRendererLookup.LookupGroup dst; 


	public void Apply() { }

	public void Clear() { }

	public void Add(MeshRendererInstance instance) { }

	public MeshRendererLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 10889
{
	public List<MeshRendererLookup.LookupEntry> data; 


	public void Clear() { }

	public void Add(MeshRendererInstance instance) { }

	public MeshRendererLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 10890
{
	public Renderer renderer; 


	public void .ctor(MeshRendererInstance instance) { }

}

