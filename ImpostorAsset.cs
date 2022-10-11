public class ImpostorAsset : ScriptableObject // TypeDefIndex: 12398
{
	public ImpostorAsset.TextureEntry[] textures; 
	public Vector2 size; 
	public Vector2 pivot; 
	public Mesh mesh; 


	public Texture2D FindTexture(string name) { }

	public void .ctor() { }

}

public class ImpostorAsset.TextureEntry // TypeDefIndex: 12399
{
	public string name; 
	public Texture2D texture; 


	public void .ctor(string name, Texture2D texture) { }

}

