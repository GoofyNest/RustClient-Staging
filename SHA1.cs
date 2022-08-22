public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 984
{	// Methods

	// RVA: 0x17BC7C0 Offset: 0x17BADC0 VA: 0x1817BC7C0
	protected void .ctor() { }

	// RVA: 0x17BC6A0 Offset: 0x17BACA0 VA: 0x1817BC6A0
	public static SHA1 Create() { }

}

public class SHA1Managed : SHA1 // TypeDefIndex: 985
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x17BC5A0 Offset: 0x17BABA0 VA: 0x1817BC5A0
	public void .ctor() { }

	// RVA: 0x17BBA90 Offset: 0x17BA090 VA: 0x1817BBA90 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BBA70 Offset: 0x17BA070 VA: 0x1817BBA70 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BBA80 Offset: 0x17BA080 VA: 0x1817BBA80 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17049B0 Offset: 0x1702FB0 VA: 0x1817049B0
	private void InitializeState() { }

	// RVA: 0x17BC430 Offset: 0x17BAA30 VA: 0x1817BC430
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BC0D0 Offset: 0x17BA6D0 VA: 0x1817BC0D0
	private byte[] _EndHash() { }

	// RVA: 0x17BBB20 Offset: 0x17BA120 VA: 0x1817BBB20
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BBAE0 Offset: 0x17BA0E0 VA: 0x1817BBAE0
	private static void SHAExpand(uint* x) { }

}

public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 986
{	// Methods

	// RVA: 0x17BDB60 Offset: 0x17BC160 VA: 0x1817BDB60
	protected void .ctor() { }

	// RVA: 0x17BDA30 Offset: 0x17BC030 VA: 0x1817BDA30
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

	// RVA: 0x17BD850 Offset: 0x17BBE50 VA: 0x1817BD850
	public void .ctor() { }

	// RVA: 0x17BC990 Offset: 0x17BAF90 VA: 0x1817BC990 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BC7F0 Offset: 0x17BADF0 VA: 0x1817BC7F0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BC800 Offset: 0x17BAE00 VA: 0x1817BC800 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BC810 Offset: 0x17BAE10 VA: 0x1817BC810
	private void InitializeState() { }

	// RVA: 0x17BD610 Offset: 0x17BBC10 VA: 0x1817BD610
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BD2B0 Offset: 0x17BB8B0 VA: 0x1817BD2B0
	private byte[] _EndHash() { }

	// RVA: 0x17BCAC0 Offset: 0x17BB0C0 VA: 0x1817BCAC0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BC9F0 Offset: 0x17BAFF0 VA: 0x1817BC9F0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x17BC7E0 Offset: 0x17BADE0 VA: 0x1817BC7E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x17BC9E0 Offset: 0x17BAFE0 VA: 0x1817BC9E0
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x17BD950 Offset: 0x17BBF50 VA: 0x1817BD950
	private static uint sigma_0(uint x) { }

	// RVA: 0x17BD9C0 Offset: 0x17BBFC0 VA: 0x1817BD9C0
	private static uint sigma_1(uint x) { }

	// RVA: 0x17BD1D0 Offset: 0x17BB7D0 VA: 0x1817BD1D0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x17BD240 Offset: 0x17BB840 VA: 0x1817BD240
	private static uint Sigma_1(uint x) { }

	// RVA: 0x17BCA10 Offset: 0x17BB010 VA: 0x1817BCA10
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x17BD7E0 Offset: 0x17BBDE0 VA: 0x1817BD7E0
	private static void .cctor() { }

}

public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 988
{	// Methods

	// RVA: 0x17BEF30 Offset: 0x17BD530 VA: 0x1817BEF30
	protected void .ctor() { }

	// RVA: 0x17BEE00 Offset: 0x17BD400 VA: 0x1817BEE00
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

	// RVA: 0x17BEC00 Offset: 0x17BD200 VA: 0x1817BEC00
	public void .ctor() { }

	// RVA: 0x17BDD70 Offset: 0x17BC370 VA: 0x1817BDD70 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BDB90 Offset: 0x17BC190 VA: 0x1817BDB90 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BDBA0 Offset: 0x17BC1A0 VA: 0x1817BDBA0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BDBB0 Offset: 0x17BC1B0 VA: 0x1817BDBB0
	private void InitializeState() { }

	// RVA: 0x17BE9C0 Offset: 0x17BCFC0 VA: 0x1817BE9C0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BE780 Offset: 0x17BCD80 VA: 0x1817BE780
	private byte[] _EndHash() { }

	// RVA: 0x17BDEA0 Offset: 0x17BC4A0 VA: 0x1817BDEA0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BDDD0 Offset: 0x17BC3D0 VA: 0x1817BDDD0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BDB80 Offset: 0x17BC180 VA: 0x1817BDB80
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BDDC0 Offset: 0x17BC3C0 VA: 0x1817BDDC0
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BE680 Offset: 0x17BCC80 VA: 0x1817BE680
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17BE700 Offset: 0x17BCD00 VA: 0x1817BE700
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17BED00 Offset: 0x17BD300 VA: 0x1817BED00
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17BED80 Offset: 0x17BD380 VA: 0x1817BED80
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17BDDF0 Offset: 0x17BC3F0 VA: 0x1817BDDF0
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x17BEB90 Offset: 0x17BD190 VA: 0x1817BEB90
	private static void .cctor() { }

}

public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 990
{	// Methods

	// RVA: 0x17C02C0 Offset: 0x17BE8C0 VA: 0x1817C02C0
	protected void .ctor() { }

	// RVA: 0x17C0190 Offset: 0x17BE790 VA: 0x1817C0190
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

	// RVA: 0x17BFF90 Offset: 0x17BE590 VA: 0x1817BFF90
	public void .ctor() { }

	// RVA: 0x17BF130 Offset: 0x17BD730 VA: 0x1817BF130 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BEF50 Offset: 0x17BD550 VA: 0x1817BEF50 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BEF60 Offset: 0x17BD560 VA: 0x1817BEF60 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BEF70 Offset: 0x17BD570 VA: 0x1817BEF70
	private void InitializeState() { }

	// RVA: 0x17BFD50 Offset: 0x17BE350 VA: 0x1817BFD50
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BFB10 Offset: 0x17BE110 VA: 0x1817BFB10
	private byte[] _EndHash() { }

	// RVA: 0x17BF230 Offset: 0x17BD830 VA: 0x1817BF230
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BDDD0 Offset: 0x17BC3D0 VA: 0x1817BDDD0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BDB80 Offset: 0x17BC180 VA: 0x1817BDB80
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BDDC0 Offset: 0x17BC3C0 VA: 0x1817BDDC0
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BFA10 Offset: 0x17BE010 VA: 0x1817BFA10
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17BFA90 Offset: 0x17BE090 VA: 0x1817BFA90
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17C0090 Offset: 0x17BE690 VA: 0x1817C0090
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17C0110 Offset: 0x17BE710 VA: 0x1817C0110
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17BF180 Offset: 0x17BD780 VA: 0x1817BF180
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x17BFF20 Offset: 0x17BE520 VA: 0x1817BFF20
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

	// RVA: 0x17BB9D0 Offset: 0x17B9FD0 VA: 0x1817BB9D0
	public void .ctor() { }

	// RVA: 0x17BA100 Offset: 0x17B8700 VA: 0x1817BA100
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BA220 Offset: 0x17B8820 VA: 0x1817BA220
	public byte[] HashFinal() { }

	// RVA: 0x17BAF00 Offset: 0x17B9500 VA: 0x1817BAF00
	public void Initialize() { }

	// RVA: 0x17BAFE0 Offset: 0x17B95E0 VA: 0x1817BAFE0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x17BA330 Offset: 0x17B8930 VA: 0x1817BA330
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x17B9B20 Offset: 0x17B8120 VA: 0x1817B9B20
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x17BB810 Offset: 0x17B9E10 VA: 0x1817BB810
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17B99B0 Offset: 0x17B7FB0 VA: 0x1817B99B0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

}

public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 1012
{	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x17B98C0 Offset: 0x17B7EC0 VA: 0x1817B98C0
	public void .ctor() { }

	// RVA: 0x17011A0 Offset: 0x16FF7A0 VA: 0x1817011A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B9640 Offset: 0x17B7C40 VA: 0x1817B9640 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B9650 Offset: 0x17B7C50 VA: 0x1817B9650 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17B9780 Offset: 0x17B7D80 VA: 0x1817B9780 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17B98A0 Offset: 0x17B7EA0 VA: 0x1817B98A0 Slot: 16
	public override void Initialize() { }

}

