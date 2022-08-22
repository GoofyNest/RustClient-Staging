internal struct HTML_BrowserReady_t : ICallbackData // TypeDefIndex: 5451
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9BD0 Offset: 0x1E8FD0 VA: 0x1801E9BD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9BC0 Offset: 0x1E8FC0 VA: 0x1801E9BC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370F40 Offset: 0x136F540 VA: 0x181370F40
	private static void .cctor() { }

}

internal struct HTML_NeedsPaint_t : ICallbackData // TypeDefIndex: 5452
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PBGRA; // 0x8
	internal uint UnWide; // 0x10
	internal uint UnTall; // 0x14
	internal uint UnUpdateX; // 0x18
	internal uint UnUpdateY; // 0x1C
	internal uint UnUpdateWide; // 0x20
	internal uint UnUpdateTall; // 0x24
	internal uint UnScrollX; // 0x28
	internal uint UnScrollY; // 0x2C
	internal float FlPageScale; // 0x30
	internal uint UnPageSerial; // 0x34
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA2A0 Offset: 0x1E96A0 VA: 0x1801EA2A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA290 Offset: 0x1E9690 VA: 0x1801EA290 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13716C0 Offset: 0x136FCC0 VA: 0x1813716C0
	private static void .cctor() { }

}

internal struct HTML_StartRequest_t : ICallbackData // TypeDefIndex: 5453
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchTarget; // 0x10
	internal string PchPostData; // 0x18
	internal bool BIsRedirect; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA6E0 Offset: 0x1E9AE0 VA: 0x1801EA6E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA6D0 Offset: 0x1E9AD0 VA: 0x1801EA6D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371A80 Offset: 0x1370080 VA: 0x181371A80
	private static void .cctor() { }

}

internal struct HTML_CloseBrowser_t : ICallbackData // TypeDefIndex: 5454
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9DE0 Offset: 0x1E91E0 VA: 0x1801E9DE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9DD0 Offset: 0x1E91D0 VA: 0x1801E9DD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13711C0 Offset: 0x136F7C0 VA: 0x1813711C0
	private static void .cctor() { }

}

internal struct HTML_URLChanged_t : ICallbackData // TypeDefIndex: 5455
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPostData; // 0x10
	internal bool BIsRedirect; // 0x18
	internal string PchPageTitle; // 0x20
	internal bool BNewNavigation; // 0x28
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA8E0 Offset: 0x1E9CE0 VA: 0x1801EA8E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA8D0 Offset: 0x1E9CD0 VA: 0x1801EA8D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371BC0 Offset: 0x13701C0 VA: 0x181371BC0
	private static void .cctor() { }

}

internal struct HTML_FinishedRequest_t : ICallbackData // TypeDefIndex: 5456
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPageTitle; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9F50 Offset: 0x1E9350 VA: 0x1801E9F50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9F40 Offset: 0x1E9340 VA: 0x1801E9F40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371300 Offset: 0x136F900 VA: 0x181371300
	private static void .cctor() { }

}

internal struct HTML_OpenLinkInNewTab_t : ICallbackData // TypeDefIndex: 5457
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA520 Offset: 0x1E9920 VA: 0x1801EA520 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA510 Offset: 0x1E9910 VA: 0x1801EA510 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371800 Offset: 0x136FE00 VA: 0x181371800
	private static void .cctor() { }

}

internal struct HTML_ChangedTitle_t : ICallbackData // TypeDefIndex: 5458
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9D20 Offset: 0x1E9120 VA: 0x1801E9D20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9D10 Offset: 0x1E9110 VA: 0x1801E9D10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371120 Offset: 0x136F720 VA: 0x181371120
	private static void .cctor() { }

}

internal struct HTML_SearchResults_t : ICallbackData // TypeDefIndex: 5459
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnResults; // 0x4
	internal uint UnCurrentMatch; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA590 Offset: 0x1E9990 VA: 0x1801EA590 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA580 Offset: 0x1E9980 VA: 0x1801EA580 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13718A0 Offset: 0x136FEA0 VA: 0x1813718A0
	private static void .cctor() { }

}

internal struct HTML_CanGoBackAndForward_t : ICallbackData // TypeDefIndex: 5460
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal bool BCanGoBack; // 0x4
	internal bool BCanGoForward; // 0x5
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9CB0 Offset: 0x1E90B0 VA: 0x1801E9CB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9CA0 Offset: 0x1E90A0 VA: 0x1801E9CA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371080 Offset: 0x136F680 VA: 0x181371080
	private static void .cctor() { }

}

internal struct HTML_HorizontalScroll_t : ICallbackData // TypeDefIndex: 5461
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA030 Offset: 0x1E9430 VA: 0x1801EA030 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA020 Offset: 0x1E9420 VA: 0x1801EA020 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371440 Offset: 0x136FA40 VA: 0x181371440
	private static void .cctor() { }

}

internal struct HTML_VerticalScroll_t : ICallbackData // TypeDefIndex: 5462
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAAF0 Offset: 0x1E9EF0 VA: 0x1801EAAF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAAE0 Offset: 0x1E9EE0 VA: 0x1801EAAE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371D00 Offset: 0x1370300 VA: 0x181371D00
	private static void .cctor() { }

}

internal struct HTML_LinkAtPosition_t : ICallbackData // TypeDefIndex: 5463
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint X; // 0x4
	internal uint Y; // 0x8
	internal string PchURL; // 0x10
	internal bool BInput; // 0x18
	internal bool BLiveLink; // 0x19
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA180 Offset: 0x1E9580 VA: 0x1801EA180 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA170 Offset: 0x1E9570 VA: 0x1801EA170 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371620 Offset: 0x136FC20 VA: 0x181371620
	private static void .cctor() { }

}

internal struct HTML_JSAlert_t : ICallbackData // TypeDefIndex: 5464
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA0A0 Offset: 0x1E94A0 VA: 0x1801EA0A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA090 Offset: 0x1E9490 VA: 0x1801EA090 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13714E0 Offset: 0x136FAE0 VA: 0x1813714E0
	private static void .cctor() { }

}

internal struct HTML_JSConfirm_t : ICallbackData // TypeDefIndex: 5465
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA110 Offset: 0x1E9510 VA: 0x1801EA110 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA100 Offset: 0x1E9500 VA: 0x1801EA100 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371580 Offset: 0x136FB80 VA: 0x181371580
	private static void .cctor() { }

}

internal struct HTML_FileOpenDialog_t : ICallbackData // TypeDefIndex: 5466
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	internal string PchInitialFile; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9E50 Offset: 0x1E9250 VA: 0x1801E9E50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9E40 Offset: 0x1E9240 VA: 0x1801E9E40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371260 Offset: 0x136F860 VA: 0x181371260
	private static void .cctor() { }

}

internal struct HTML_NewWindow_t : ICallbackData // TypeDefIndex: 5467
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal uint UnX; // 0x10
	internal uint UnY; // 0x14
	internal uint UnWide; // 0x18
	internal uint UnTall; // 0x1C
	internal uint UnNewWindow_BrowserHandle_IGNORE; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA400 Offset: 0x1E9800 VA: 0x1801EA400 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA3F0 Offset: 0x1E97F0 VA: 0x1801EA3F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371760 Offset: 0x136FD60 VA: 0x181371760
	private static void .cctor() { }

}

internal struct HTML_SetCursor_t : ICallbackData // TypeDefIndex: 5468
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint EMouseCursor; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA600 Offset: 0x1E9A00 VA: 0x1801EA600 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA5F0 Offset: 0x1E99F0 VA: 0x1801EA5F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371940 Offset: 0x136FF40 VA: 0x181371940
	private static void .cctor() { }

}

internal struct HTML_StatusText_t : ICallbackData // TypeDefIndex: 5469
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA870 Offset: 0x1E9C70 VA: 0x1801EA870 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA860 Offset: 0x1E9C60 VA: 0x1801EA860 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371B20 Offset: 0x1370120 VA: 0x181371B20
	private static void .cctor() { }

}

internal struct HTML_ShowToolTip_t : ICallbackData // TypeDefIndex: 5470
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA670 Offset: 0x1E9A70 VA: 0x1801EA670 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA660 Offset: 0x1E9A60 VA: 0x1801EA660 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13719E0 Offset: 0x136FFE0 VA: 0x1813719E0
	private static void .cctor() { }

}

internal struct HTML_UpdateToolTip_t : ICallbackData // TypeDefIndex: 5471
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAA80 Offset: 0x1E9E80 VA: 0x1801EAA80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAA70 Offset: 0x1E9E70 VA: 0x1801EAA70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371C60 Offset: 0x1370260 VA: 0x181371C60
	private static void .cctor() { }

}

internal struct HTML_HideToolTip_t : ICallbackData // TypeDefIndex: 5472
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9FC0 Offset: 0x1E93C0 VA: 0x1801E9FC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9FB0 Offset: 0x1E93B0 VA: 0x1801E9FB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13713A0 Offset: 0x136F9A0 VA: 0x1813713A0
	private static void .cctor() { }

}

internal struct HTML_BrowserRestarted_t : ICallbackData // TypeDefIndex: 5473
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnOldBrowserHandle; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9C40 Offset: 0x1E9040 VA: 0x1801E9C40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9C30 Offset: 0x1E9030 VA: 0x1801E9C30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370FE0 Offset: 0x136F5E0 VA: 0x181370FE0
	private static void .cctor() { }

}

