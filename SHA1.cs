public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 984
{	// Methods

	// RVA: 0x17BEC70 Offset: 0x17BD270 VA: 0x1817BEC70
	protected void .ctor() { }

	// RVA: 0x17BEB50 Offset: 0x17BD150 VA: 0x1817BEB50
	public static SHA1 Create() { }

}

public class SHA1Managed : SHA1 // TypeDefIndex: 985
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x17BEA50 Offset: 0x17BD050 VA: 0x1817BEA50
	public void .ctor() { }

	// RVA: 0x17BDF40 Offset: 0x17BC540 VA: 0x1817BDF40 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BDF20 Offset: 0x17BC520 VA: 0x1817BDF20 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BDF30 Offset: 0x17BC530 VA: 0x1817BDF30 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1706DC0 Offset: 0x17053C0 VA: 0x181706DC0
	private void InitializeState() { }

	// RVA: 0x17BE8E0 Offset: 0x17BCEE0 VA: 0x1817BE8E0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BE580 Offset: 0x17BCB80 VA: 0x1817BE580
	private byte[] _EndHash() { }

	// RVA: 0x17BDFD0 Offset: 0x17BC5D0 VA: 0x1817BDFD0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BDF90 Offset: 0x17BC590 VA: 0x1817BDF90
	private static void SHAExpand(uint* x) { }

}

public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 986
{	// Methods

	// RVA: 0x17C0010 Offset: 0x17BE610 VA: 0x1817C0010
	protected void .ctor() { }

	// RVA: 0x17BFEE0 Offset: 0x17BE4E0 VA: 0x1817BFEE0
	public static SHA256 Create() { }

}

public class SHA256Managed : SHA256 // TypeDefIndex: 987
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x17BFD00 Offset: 0x17BE300 VA: 0x1817BFD00
	public void .ctor() { }

	// RVA: 0x17BEE40 Offset: 0x17BD440 VA: 0x1817BEE40 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BECA0 Offset: 0x17BD2A0 VA: 0x1817BECA0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BECB0 Offset: 0x17BD2B0 VA: 0x1817BECB0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BECC0 Offset: 0x17BD2C0 VA: 0x1817BECC0
	private void InitializeState() { }

	// RVA: 0x17BFAC0 Offset: 0x17BE0C0 VA: 0x1817BFAC0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BF760 Offset: 0x17BDD60 VA: 0x1817BF760
	private byte[] _EndHash() { }

	// RVA: 0x17BEF70 Offset: 0x17BD570 VA: 0x1817BEF70
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BEEA0 Offset: 0x17BD4A0 VA: 0x1817BEEA0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x17BEC90 Offset: 0x17BD290 VA: 0x1817BEC90
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x17BEE90 Offset: 0x17BD490 VA: 0x1817BEE90
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x17BFE00 Offset: 0x17BE400 VA: 0x1817BFE00
	private static uint sigma_0(uint x) { }

	// RVA: 0x17BFE70 Offset: 0x17BE470 VA: 0x1817BFE70
	private static uint sigma_1(uint x) { }

	// RVA: 0x17BF680 Offset: 0x17BDC80 VA: 0x1817BF680
	private static uint Sigma_0(uint x) { }

	// RVA: 0x17BF6F0 Offset: 0x17BDCF0 VA: 0x1817BF6F0
	private static uint Sigma_1(uint x) { }

	// RVA: 0x17BEEC0 Offset: 0x17BD4C0 VA: 0x1817BEEC0
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x17BFC90 Offset: 0x17BE290 VA: 0x1817BFC90
	private static void .cctor() { }

}

public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 988
{	// Methods

	// RVA: 0x17C13E0 Offset: 0x17BF9E0 VA: 0x1817C13E0
	protected void .ctor() { }

	// RVA: 0x17C12B0 Offset: 0x17BF8B0 VA: 0x1817C12B0
	public static SHA384 Create() { }

}

public class SHA384Managed : SHA384 // TypeDefIndex: 989
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17C10B0 Offset: 0x17BF6B0 VA: 0x1817C10B0
	public void .ctor() { }

	// RVA: 0x17C0220 Offset: 0x17BE820 VA: 0x1817C0220 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17C0040 Offset: 0x17BE640 VA: 0x1817C0040 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17C0050 Offset: 0x17BE650 VA: 0x1817C0050 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17C0060 Offset: 0x17BE660 VA: 0x1817C0060
	private void InitializeState() { }

	// RVA: 0x17C0E70 Offset: 0x17BF470 VA: 0x1817C0E70
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17C0C30 Offset: 0x17BF230 VA: 0x1817C0C30
	private byte[] _EndHash() { }

	// RVA: 0x17C0350 Offset: 0x17BE950 VA: 0x1817C0350
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17C0280 Offset: 0x17BE880 VA: 0x1817C0280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17C0030 Offset: 0x17BE630 VA: 0x1817C0030
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C0270 Offset: 0x17BE870 VA: 0x1817C0270
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C0B30 Offset: 0x17BF130 VA: 0x1817C0B30
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17C0BB0 Offset: 0x17BF1B0 VA: 0x1817C0BB0
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17C11B0 Offset: 0x17BF7B0 VA: 0x1817C11B0
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17C1230 Offset: 0x17BF830 VA: 0x1817C1230
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17C02A0 Offset: 0x17BE8A0 VA: 0x1817C02A0
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x17C1040 Offset: 0x17BF640 VA: 0x1817C1040
	private static void .cctor() { }

}

public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 990
{	// Methods

	// RVA: 0x17C2770 Offset: 0x17C0D70 VA: 0x1817C2770
	protected void .ctor() { }

	// RVA: 0x17C2640 Offset: 0x17C0C40 VA: 0x1817C2640
	public static SHA512 Create() { }

}

public class SHA512Managed : SHA512 // TypeDefIndex: 991
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17C2440 Offset: 0x17C0A40 VA: 0x1817C2440
	public void .ctor() { }

	// RVA: 0x17C15E0 Offset: 0x17BFBE0 VA: 0x1817C15E0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17C1400 Offset: 0x17BFA00 VA: 0x1817C1400 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17C1410 Offset: 0x17BFA10 VA: 0x1817C1410 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17C1420 Offset: 0x17BFA20 VA: 0x1817C1420
	private void InitializeState() { }

	// RVA: 0x17C2200 Offset: 0x17C0800 VA: 0x1817C2200
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17C1FC0 Offset: 0x17C05C0 VA: 0x1817C1FC0
	private byte[] _EndHash() { }

	// RVA: 0x17C16E0 Offset: 0x17BFCE0 VA: 0x1817C16E0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17C0280 Offset: 0x17BE880 VA: 0x1817C0280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17C0030 Offset: 0x17BE630 VA: 0x1817C0030
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C0270 Offset: 0x17BE870 VA: 0x1817C0270
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C1EC0 Offset: 0x17C04C0 VA: 0x1817C1EC0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17C1F40 Offset: 0x17C0540 VA: 0x1817C1F40
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17C2540 Offset: 0x17C0B40 VA: 0x1817C2540
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17C25C0 Offset: 0x17C0BC0 VA: 0x1817C25C0
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17C1630 Offset: 0x17BFC30 VA: 0x1817C1630
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x17C23D0 Offset: 0x17C09D0 VA: 0x1817C23D0
	private static void .cctor() { }

}

internal class SHA1Internal // TypeDefIndex: 1011
{	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x17BDE80 Offset: 0x17BC480 VA: 0x1817BDE80
	public void .ctor() { }

	// RVA: 0x17BC5B0 Offset: 0x17BABB0 VA: 0x1817BC5B0
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BC6D0 Offset: 0x17BACD0 VA: 0x1817BC6D0
	public byte[] HashFinal() { }

	// RVA: 0x17BD3B0 Offset: 0x17BB9B0 VA: 0x1817BD3B0
	public void Initialize() { }

	// RVA: 0x17BD490 Offset: 0x17BBA90 VA: 0x1817BD490
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x17BC7E0 Offset: 0x17BADE0 VA: 0x1817BC7E0
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x17BBFD0 Offset: 0x17BA5D0 VA: 0x1817BBFD0
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x17BDCC0 Offset: 0x17BC2C0 VA: 0x1817BDCC0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17BBE60 Offset: 0x17BA460 VA: 0x1817BBE60
	internal void AddLength(ulong length, byte[] buffer, int position) { }

}

public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 1012
{	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x17BBD70 Offset: 0x17BA370 VA: 0x1817BBD70
	public void .ctor() { }

	// RVA: 0x17035B0 Offset: 0x1701BB0 VA: 0x1817035B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17BBAF0 Offset: 0x17BA0F0 VA: 0x1817BBAF0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17BBB00 Offset: 0x17BA100 VA: 0x1817BBB00 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BBC30 Offset: 0x17BA230 VA: 0x1817BBC30 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BBD50 Offset: 0x17BA350 VA: 0x1817BBD50 Slot: 16
	public override void Initialize() { }

}

