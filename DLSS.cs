public static class DLSS // TypeDefIndex: 8224
{	// Methods

	// RVA: 0x106BF50 Offset: 0x106A550 VA: 0x18106BF50
	public static extern bool InitDLSS() { }

	// RVA: 0x106BEE0 Offset: 0x106A4E0 VA: 0x18106BEE0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x106BFC0 Offset: 0x106A5C0 VA: 0x18106BFC0
	public static extern bool InitializeFeatures(uint optimalWidth, uint optimalHeight, uint displayWidth, uint displayHeight, int isHDR, bool lowResMotionVectors, bool depthInverted, float depthScale, NVSDK_NGX_PerfQuality_Value quality) { }

	// RVA: 0x106C0B0 Offset: 0x106A6B0 VA: 0x18106C0B0
	public static extern bool QueryOptimalSettings(uint displayWidth, uint displayHeight, NVSDK_NGX_PerfQuality_Value quality, ref DlSSRecommendedSettings outRecommendedSettings) { }

	// RVA: 0x106C150 Offset: 0x106A750 VA: 0x18106C150
	public static extern bool ReleaseFeatures() { }

	// RVA: 0x106C1C0 Offset: 0x106A7C0 VA: 0x18106C1C0
	public static extern void ShutdownDLSS() { }

}

