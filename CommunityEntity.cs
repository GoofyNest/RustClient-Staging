public class CommunityEntity : PointEntity // TypeDefIndex: 8551
{	// Fields
	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages; // 0x0
	private static Dictionary<uint, CommunityEntity.CachedTexture> _textureCache; // 0x8
	private static List<GameObject> AllUi; // 0x10
	private static Dictionary<string, GameObject> UiDict; // 0x18
	public static CommunityEntity ServerInstance; // 0x20
	public static CommunityEntity ClientInstance; // 0x28

	// Methods

	// RVA: 0x580BF0 Offset: 0x57F1F0 VA: 0x180580BF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57ECC0 Offset: 0x57D2C0 VA: 0x18057ECC0
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg) { }

	// RVA: 0x580960 Offset: 0x57EF60 VA: 0x180580960
	private static CommunityEntity.CachedTexture GetCachedTexture(uint textureId) { }

	// RVA: 0x5817F0 Offset: 0x57FDF0 VA: 0x1805817F0
	private CommunityEntity.CachedTexture StoreCachedTexture(uint textureId, byte[] bytes) { }

	// RVA: 0x57EA20 Offset: 0x57D020 VA: 0x18057EA20
	private void ApplyTextureToImage(MaskableGraphic component, uint textureID) { }

	// RVA: 0x57E7A0 Offset: 0x57CDA0 VA: 0x18057E7A0
	private void ApplyCachedTextureToImage(MaskableGraphic component, CommunityEntity.CachedTexture texture) { }

	// RVA: 0x581970 Offset: 0x57FF70 VA: 0x180581970
	private static void UnloadTextureCache() { }

	// RVA: 0x580540 Offset: 0x57EB40 VA: 0x180580540
	public static void DestroyServerCreatedUI() { }

	// RVA: 0x581740 Offset: 0x57FD40 VA: 0x180581740
	public void SetVisible(bool b) { }

	// RVA: 0x581680 Offset: 0x57FC80 VA: 0x180581680
	private static void RegisterUi(GameObject go) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57E000 Offset: 0x57C600 VA: 0x18057E000
	public void AddUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x580850 Offset: 0x57EE50 VA: 0x180580850
	private GameObject FindPanel(string name) { }

	// RVA: 0x57EF80 Offset: 0x57D580 VA: 0x18057EF80
	private void CreateComponents(GameObject go, Object obj) { }

	// RVA: -1 Offset: -1
	private static T ParseEnum<T>(string value, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB3B0 Offset: 0x5C99B0 VA: 0x1805CB3B0
	|-CommunityEntity.ParseEnum<Int32Enum>
	|-CommunityEntity.ParseEnum<TextAnchor>
	|-CommunityEntity.ParseEnum<Image.Type>
	|-CommunityEntity.ParseEnum<InputField.LineType>
	|-CommunityEntity.ParseEnum<VerticalWrapMode>
	*/

	// RVA: 0x5809F0 Offset: 0x57EFF0 VA: 0x1805809F0
	private void GraphicComponentCreated(Graphic c, Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xAA280 Offset: 0xA9680 VA: 0x1800AA280
	// RVA: 0x580B60 Offset: 0x57F160 VA: 0x180580B60
	private IEnumerator LoadTextureFromWWW(RawImage c, string p) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x580800 Offset: 0x57EE00 VA: 0x180580800
	public void DestroyUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5803A0 Offset: 0x57E9A0 VA: 0x1805803A0
	private void DestroyPanel(string pnlName) { }

	// RVA: 0x580AB0 Offset: 0x57F0B0 VA: 0x180580AB0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x580750 Offset: 0x57ED50 VA: 0x180580750 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x581C50 Offset: 0x580250 VA: 0x180581C50
	public void .ctor() { }

	// RVA: 0x581B00 Offset: 0x580100 VA: 0x180581B00
	private static void .cctor() { }

}

private class CommunityEntity.Countdown : MonoBehaviour // TypeDefIndex: 8552
{	// Fields
	public string command; // 0x18
	public int endTime; // 0x20
	public int startTime; // 0x24
	public int step; // 0x28
	private int sign; // 0x2C
	private string tempText; // 0x30
	private Text textComponent; // 0x38

	// Methods

	// RVA: 0x5839A0 Offset: 0x581FA0 VA: 0x1805839A0
	private void Start() { }

	// RVA: 0x583B10 Offset: 0x582110 VA: 0x180583B10
	private void UpdateCountdown() { }

	// RVA: 0x5838C0 Offset: 0x581EC0 VA: 0x1805838C0
	private void End() { }

	// RVA: 0x583C10 Offset: 0x582210 VA: 0x180583C10
	public void .ctor() { }

}

private class CommunityEntity.FadeOut : MonoBehaviour // TypeDefIndex: 8553
{	// Fields
	public float duration; // 0x18

	// Methods

	// RVA: 0x583CE0 Offset: 0x5822E0 VA: 0x180583CE0
	public void FadeOutAndDestroy() { }

	// RVA: 0x583DC0 Offset: 0x5823C0 VA: 0x180583DC0
	public void Kill() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private class CommunityEntity.CachedTexture // TypeDefIndex: 8554
{	// Fields
	public Texture2D Texture; // 0x10
	public Sprite Sprite; // 0x18

	// Methods

	// RVA: 0x56FAF0 Offset: 0x56E0F0 VA: 0x18056FAF0
	public void Destroy() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_0 // TypeDefIndex: 8555
{	// Fields
	public Image c; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_1 // TypeDefIndex: 8556
{	// Fields
	public ulong requestedSkin; // 0x10
	public CommunityEntity.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3BA0 Offset: 0x4B21A0 VA: 0x1804B3BA0
	internal bool <CreateComponents>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x589B70 Offset: 0x588170 VA: 0x180589B70
	internal void <CreateComponents>b__1() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_2 // TypeDefIndex: 8557
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589C20 Offset: 0x588220 VA: 0x180589C20
	internal void <CreateComponents>b__2() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_3 // TypeDefIndex: 8558
{	// Fields
	public string pnlName; // 0x10
	public CommunityEntity <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589C30 Offset: 0x588230 VA: 0x180589C30
	internal void <CreateComponents>b__3() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_4 // TypeDefIndex: 8559
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589C60 Offset: 0x588260 VA: 0x180589C60
	internal void <CreateComponents>b__4(string value) { }

}

private sealed class CommunityEntity.<LoadTextureFromWWW>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8560
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string p; // 0x20
	public RawImage c; // 0x28
	private WWW <www>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5875B0 Offset: 0x585BB0 VA: 0x1805875B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5879D0 Offset: 0x585FD0 VA: 0x1805879D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

