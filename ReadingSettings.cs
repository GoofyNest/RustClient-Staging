public class ReadingSettings // TypeDefIndex: 7601
{	// Fields
	private UnexpectedTrackChunksCountPolicy _unexpectedTrackChunksCountPolicy; // 0x10
	private ExtraTrackChunkPolicy _extraTrackChunkPolicy; // 0x14
	private UnknownChunkIdPolicy _unknownChunkIdPolicy; // 0x15
	private MissedEndOfTrackPolicy _missedEndOfTrackPolicy; // 0x16
	private SilentNoteOnPolicy _silentNoteOnPolicy; // 0x17
	private InvalidChunkSizePolicy _invalidChunkSizePolicy; // 0x18
	private UnknownFileFormatPolicy _unknownFileFormatPolicy; // 0x1C
	private UnknownChannelEventPolicy _unknownChannelEventPolicy; // 0x20
	private InvalidChannelEventParameterValuePolicy _invalidChannelEventParameterValuePolicy; // 0x24
	private InvalidMetaEventParameterValuePolicy _invalidMetaEventParameterValuePolicy; // 0x28
	private InvalidSystemCommonEventParameterValuePolicy _invalidSystemCommonEventParameterValuePolicy; // 0x2C
	private NotEnoughBytesPolicy _notEnoughBytesPolicy; // 0x30
	private NoHeaderChunkPolicy _noHeaderChunkPolicy; // 0x34
	private ZeroLengthDataPolicy _zeroLengthDataPolicy; // 0x38
	private EndOfTrackStoringPolicy _endOfTrackStoringPolicy; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UnknownChannelEventCallback <UnknownChannelEventCallback>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ChunkTypesCollection <CustomChunkTypes>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventTypesCollection <CustomMetaEventTypes>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Encoding <TextEncoding>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DecodeTextCallback <DecodeTextCallback>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ReaderSettings <ReaderSettings>k__BackingField; // 0x68

	// Properties
	public UnexpectedTrackChunksCountPolicy UnexpectedTrackChunksCountPolicy { get; }
	public ExtraTrackChunkPolicy ExtraTrackChunkPolicy { get; }
	public UnknownChunkIdPolicy UnknownChunkIdPolicy { get; }
	public MissedEndOfTrackPolicy MissedEndOfTrackPolicy { get; }
	public SilentNoteOnPolicy SilentNoteOnPolicy { get; }
	public InvalidChunkSizePolicy InvalidChunkSizePolicy { get; }
	public UnknownFileFormatPolicy UnknownFileFormatPolicy { get; }
	public UnknownChannelEventPolicy UnknownChannelEventPolicy { get; }
	public UnknownChannelEventCallback UnknownChannelEventCallback { get; }
	public InvalidChannelEventParameterValuePolicy InvalidChannelEventParameterValuePolicy { get; }
	public InvalidMetaEventParameterValuePolicy InvalidMetaEventParameterValuePolicy { get; }
	public InvalidSystemCommonEventParameterValuePolicy InvalidSystemCommonEventParameterValuePolicy { get; }
	public NotEnoughBytesPolicy NotEnoughBytesPolicy { get; }
	public NoHeaderChunkPolicy NoHeaderChunkPolicy { get; }
	public ChunkTypesCollection CustomChunkTypes { get; }
	public EventTypesCollection CustomMetaEventTypes { get; }
	public Encoding TextEncoding { get; }
	public DecodeTextCallback DecodeTextCallback { get; }
	public ZeroLengthDataPolicy ZeroLengthDataPolicy { get; }
	public EndOfTrackStoringPolicy EndOfTrackStoringPolicy { get; }
	public ReaderSettings ReaderSettings { get; set; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public UnexpectedTrackChunksCountPolicy get_UnexpectedTrackChunksCountPolicy() { }

	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public ExtraTrackChunkPolicy get_ExtraTrackChunkPolicy() { }

	// RVA: 0x13A4790 Offset: 0x13A2D90 VA: 0x1813A4790
	public UnknownChunkIdPolicy get_UnknownChunkIdPolicy() { }

	// RVA: 0x13A4770 Offset: 0x13A2D70 VA: 0x1813A4770
	public MissedEndOfTrackPolicy get_MissedEndOfTrackPolicy() { }

	// RVA: 0x13A4780 Offset: 0x13A2D80 VA: 0x1813A4780
	public SilentNoteOnPolicy get_SilentNoteOnPolicy() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public InvalidChunkSizePolicy get_InvalidChunkSizePolicy() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public UnknownFileFormatPolicy get_UnknownFileFormatPolicy() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public UnknownChannelEventPolicy get_UnknownChannelEventPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public UnknownChannelEventCallback get_UnknownChannelEventCallback() { }

	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public InvalidChannelEventParameterValuePolicy get_InvalidChannelEventParameterValuePolicy() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public InvalidMetaEventParameterValuePolicy get_InvalidMetaEventParameterValuePolicy() { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public InvalidSystemCommonEventParameterValuePolicy get_InvalidSystemCommonEventParameterValuePolicy() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public NotEnoughBytesPolicy get_NotEnoughBytesPolicy() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public NoHeaderChunkPolicy get_NoHeaderChunkPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public ChunkTypesCollection get_CustomChunkTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public EventTypesCollection get_CustomMetaEventTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Encoding get_TextEncoding() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public DecodeTextCallback get_DecodeTextCallback() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public ZeroLengthDataPolicy get_ZeroLengthDataPolicy() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public EndOfTrackStoringPolicy get_EndOfTrackStoringPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public ReaderSettings get_ReaderSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_ReaderSettings(ReaderSettings value) { }

	// RVA: 0x13A46D0 Offset: 0x13A2CD0 VA: 0x1813A46D0
	public void .ctor() { }

}

