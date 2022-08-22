public static class DLSS // TypeDefIndex: 8224
{	// Methods

	// RVA: 0x106C9C0 Offset: 0x106AFC0 VA: 0x18106C9C0
	public static extern bool InitDLSS() { }

	// RVA: 0x106C950 Offset: 0x106AF50 VA: 0x18106C950
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x106CA30 Offset: 0x106B030 VA: 0x18106CA30
	public static extern bool InitializeFeatures(uint optimalWidth, uint optimalHeight, uint displayWidth, uint displayHeight, int isHDR, bool lowResMotionVectors, bool depthInverted, float depthScale, NVSDK_NGX_PerfQuality_Value quality) { }

	// RVA: 0x106CB20 Offset: 0x106B120 VA: 0x18106CB20
	public static extern bool QueryOptimalSettings(uint displayWidth, uint displayHeight, NVSDK_NGX_PerfQuality_Value quality, ref DlSSRecommendedSettings outRecommendedSettings) { }

	// RVA: 0x106CBC0 Offset: 0x106B1C0 VA: 0x18106CBC0
	public static extern bool ReleaseFeatures() { }

	// RVA: 0x106CC30 Offset: 0x106B230 VA: 0x18106CC30
	public static extern void ShutdownDLSS() { }

}

