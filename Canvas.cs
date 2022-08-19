public sealed class Canvas : Behaviour // TypeDefIndex: 4736
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x13600

	// Properties
	public RenderMode renderMode { get; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	[NativePropertyAttribute] // RVA: 0xA5C70 Offset: 0xA5070 VA: 0x1800A5C70
	public Camera worldCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2308C60 Offset: 0x2307260 VA: 0x182308C60
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23090F0 Offset: 0x23076F0 VA: 0x1823090F0
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2308EF0 Offset: 0x23074F0 VA: 0x182308EF0
	public RenderMode get_renderMode() { }

	// RVA: 0x2308D50 Offset: 0x2307350 VA: 0x182308D50
	public bool get_isRootCanvas() { }

	// RVA: 0x2308E60 Offset: 0x2307460 VA: 0x182308E60
	public Rect get_pixelRect() { }

	// RVA: 0x2308FB0 Offset: 0x23075B0 VA: 0x182308FB0
	public float get_scaleFactor() { }

	// RVA: 0x2309280 Offset: 0x2307880 VA: 0x182309280
	public void set_scaleFactor(float value) { }

	// RVA: 0x2308EB0 Offset: 0x23074B0 VA: 0x182308EB0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2309230 Offset: 0x2307830 VA: 0x182309230
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x2308DD0 Offset: 0x23073D0 VA: 0x182308DD0
	public bool get_pixelPerfect() { }

	// RVA: 0x2308F30 Offset: 0x2307530 VA: 0x182308F30
	public int get_renderOrder() { }

	// RVA: 0x2308D90 Offset: 0x2307390 VA: 0x182308D90
	public bool get_overrideSorting() { }

	// RVA: 0x23091E0 Offset: 0x23077E0 VA: 0x1823091E0
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2309030 Offset: 0x2307630 VA: 0x182309030
	public int get_sortingOrder() { }

	// RVA: 0x2309310 Offset: 0x2307910 VA: 0x182309310
	public void set_sortingOrder(int value) { }

	// RVA: 0x2309070 Offset: 0x2307670 VA: 0x182309070
	public int get_targetDisplay() { }

	// RVA: 0x2308FF0 Offset: 0x23075F0 VA: 0x182308FF0
	public int get_sortingLayerID() { }

	// RVA: 0x23092D0 Offset: 0x23078D0 VA: 0x1823092D0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2308D10 Offset: 0x2307310 VA: 0x182308D10
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x23091A0 Offset: 0x23077A0 VA: 0x1823091A0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2308F70 Offset: 0x2307570 VA: 0x182308F70
	public Canvas get_rootCanvas() { }

	// RVA: 0x23090B0 Offset: 0x23076B0 VA: 0x1823090B0
	public Camera get_worldCamera() { }

	// RVA: 0x2309350 Offset: 0x2307950 VA: 0x182309350
	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA59F0 Offset: 0xA4DF0 VA: 0x1800A59F0
	// RVA: 0x2308C00 Offset: 0x2307200 VA: 0x182308C00
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5B00 Offset: 0xA4F00 VA: 0x1800A5B00
	// RVA: 0x2308C30 Offset: 0x2307230 VA: 0x182308C30
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x2308BB0 Offset: 0x23071B0 VA: 0x182308BB0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2308BB0 Offset: 0x23071B0 VA: 0x182308BB0
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	public void .ctor() { }

	// RVA: 0x2308E10 Offset: 0x2307410 VA: 0x182308E10
	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85B00 Offset: 0x1A84100 VA: 0x181A85B00 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

