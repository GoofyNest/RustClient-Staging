internal static class UnityTls // TypeDefIndex: 2457
{	// Fields
	private static UnityTls.unitytls_interface_struct marshalledInterface; // 0x140AA

	// Properties
	public static bool IsSupported { get; }
	public static UnityTls.unitytls_interface_struct NativeInterface { get; }

	// Methods

	// RVA: 0x12212F0 Offset: 0x121F8F0 VA: 0x1812212F0
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0x1221300 Offset: 0x121F900 VA: 0x181221300
	public static bool get_IsSupported() { }

	// RVA: 0x1221320 Offset: 0x121F920 VA: 0x181221320
	public static UnityTls.unitytls_interface_struct get_NativeInterface() { }

}

public enum UnityTls.unitytls_error_code // TypeDefIndex: 2458
{	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_error_code UNITYTLS_SUCCESS = 0;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_ARGUMENT = 1;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_FORMAT = 2;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_PASSWORD = 3;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_STATE = 4;
	public const UnityTls.unitytls_error_code UNITYTLS_BUFFER_OVERFLOW = 5;
	public const UnityTls.unitytls_error_code UNITYTLS_OUT_OF_MEMORY = 6;
	public const UnityTls.unitytls_error_code UNITYTLS_INTERNAL_ERROR = 7;
	public const UnityTls.unitytls_error_code UNITYTLS_NOT_SUPPORTED = 8;
	public const UnityTls.unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED = 9;
	public const UnityTls.unitytls_error_code UNITYTLS_STREAM_CLOSED = 10;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048578;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048579;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048580;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;

}

public struct UnityTls.unitytls_errorstate // TypeDefIndex: 2459
{	// Fields
	private uint magic; // 0x0
	public UnityTls.unitytls_error_code code; // 0x4
	private ulong reserved; // 0x8

}

public struct UnityTls.unitytls_key_ref // TypeDefIndex: 2461
{
// Namespace: 
public struct UnityTls.unitytls_key_ref // TypeDefIndex: 2461
	// Fields
	public ulong handle; // 0x0

}

public struct UnityTls.unitytls_x509_ref // TypeDefIndex: 2462
{	// Fields
	public ulong handle; // 0x0

}

public struct UnityTls.unitytls_x509list_ref // TypeDefIndex: 2464
{
// Namespace: 
public struct UnityTls.unitytls_x509list_ref // TypeDefIndex: 2464
	// Fields
	public ulong handle; // 0x0

}

public enum UnityTls.unitytls_x509verify_result // TypeDefIndex: 2465
{	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_SUCCESS = 0;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_NOT_DONE = 2147483648;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_REVOKED = 2;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728;

}

public sealed class UnityTls.unitytls_x509verify_callback : MulticastDelegate // TypeDefIndex: 2466
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1225740 Offset: 0x1223D40 VA: 0x181225740 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1225690 Offset: 0x1223C90 VA: 0x181225690 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

public enum UnityTls.unitytls_ciphersuite // TypeDefIndex: 2469
{
// Namespace: 
public struct UnityTls.unitytls_x509name // TypeDefIndex: 2468

// Namespace: 
public enum UnityTls.unitytls_ciphersuite // TypeDefIndex: 2469
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_ciphersuite UNITYTLS_CIPHERSUITE_INVALID = 16777215;

}

public enum UnityTls.unitytls_protocol // TypeDefIndex: 2470
{	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0 = 0;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1 = 1;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2 = 2;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_INVALID = 3;

}

public struct UnityTls.unitytls_tlsctx_protocolrange // TypeDefIndex: 2471
{	// Fields
	public UnityTls.unitytls_protocol min; // 0x0
	public UnityTls.unitytls_protocol max; // 0x4

}

public sealed class UnityTls.unitytls_tlsctx_write_callback : MulticastDelegate // TypeDefIndex: 2472
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223A20 Offset: 0x1222020 VA: 0x181223A20 Slot: 12
	public virtual IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224550 Offset: 0x1222B50 VA: 0x181224550 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_tlsctx_read_callback : MulticastDelegate // TypeDefIndex: 2473
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223A20 Offset: 0x1222020 VA: 0x181223A20 Slot: 12
	public virtual IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1223980 Offset: 0x1221F80 VA: 0x181223980 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_tlsctx_trace_callback : MulticastDelegate // TypeDefIndex: 2474
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen) { }

	// RVA: 0x12244B0 Offset: 0x1222AB0 VA: 0x1812244B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_tlsctx_certificate_callback : MulticastDelegate // TypeDefIndex: 2475
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222940 Offset: 0x1220F40 VA: 0x181222940 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1222850 Offset: 0x1220E50 VA: 0x181222850 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_tlsctx_x509verify_callback : MulticastDelegate // TypeDefIndex: 2476
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1224720 Offset: 0x1222D20 VA: 0x181224720 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224690 Offset: 0x1222C90 VA: 0x181224690 Slot: 13
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

public struct UnityTls.unitytls_tlsctx_callbacks // TypeDefIndex: 2477
{	// Fields
	public UnityTls.unitytls_tlsctx_read_callback read; // 0x0
	public UnityTls.unitytls_tlsctx_write_callback write; // 0x8
	public void* data; // 0x10

}

public class UnityTls.unitytls_interface_struct // TypeDefIndex: 2478
{	// Fields
	public readonly ulong UNITYTLS_INVALID_HANDLE; // 0x10
	public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
	public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
	public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free; // 0x48
	public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
	public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create; // 0x68
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append; // 0x70
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
	public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free; // 0x88
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
	public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t : MulticastDelegate // TypeDefIndex: 2479
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221420 Offset: 0x121FA20 VA: 0x181221420 Slot: 12
	public virtual UnityTls.unitytls_errorstate Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x12213E0 Offset: 0x121F9E0 VA: 0x1812213E0 Slot: 14
	public virtual UnityTls.unitytls_errorstate EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t : MulticastDelegate // TypeDefIndex: 2480
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221780 Offset: 0x121FD80 VA: 0x181221780 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode) { }

	// RVA: 0x12216F0 Offset: 0x121FCF0 VA: 0x1812216F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t : MulticastDelegate // TypeDefIndex: 2481
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221D60 Offset: 0x1220360 VA: 0x181221D60 Slot: 12
	public virtual UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual UnityTls.unitytls_key_ref EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t : MulticastDelegate // TypeDefIndex: 2482
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222130 Offset: 0x1220730 VA: 0x181222130 Slot: 12
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1222070 Offset: 0x1220670 VA: 0x181222070 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t : MulticastDelegate // TypeDefIndex: 2483
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222130 Offset: 0x1220730 VA: 0x181222130 Slot: 12
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1222400 Offset: 0x1220A00 VA: 0x181222400 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_key_free_t : MulticastDelegate // TypeDefIndex: 2484
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221A70 Offset: 0x1220070 VA: 0x181221A70 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_key* key) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t : MulticastDelegate // TypeDefIndex: 2485
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1224AE0 Offset: 0x12230E0 VA: 0x181224AE0 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224A30 Offset: 0x1223030 VA: 0x181224A30 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t : MulticastDelegate // TypeDefIndex: 2486
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221D60 Offset: 0x1220360 VA: 0x181221D60 Slot: 12
	public virtual UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual UnityTls.unitytls_x509list_ref EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t : MulticastDelegate // TypeDefIndex: 2487
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1225330 Offset: 0x1223930 VA: 0x181225330 Slot: 12
	public virtual UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1225290 Offset: 0x1223890 VA: 0x181225290 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual UnityTls.unitytls_x509_ref EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_create_t : MulticastDelegate // TypeDefIndex: 2488
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1224FB0 Offset: 0x12235B0 VA: 0x181224FB0 Slot: 12
	public virtual UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnityTls.unitytls_x509list* EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_t : MulticastDelegate // TypeDefIndex: 2489
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223DE0 Offset: 0x12223E0 VA: 0x181223DE0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224F20 Offset: 0x1223520 VA: 0x181224F20 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t : MulticastDelegate // TypeDefIndex: 2490
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224E80 Offset: 0x1223480 VA: 0x181224E80 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_free_t : MulticastDelegate // TypeDefIndex: 2491
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221A70 Offset: 0x1220070 VA: 0x181221A70 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t : MulticastDelegate // TypeDefIndex: 2492
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1225B50 Offset: 0x1224150 VA: 0x181225B50 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1225A80 Offset: 0x1224080 VA: 0x181225A80 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t : MulticastDelegate // TypeDefIndex: 2493
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1226040 Offset: 0x1224640 VA: 0x181226040 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1225F60 Offset: 0x1224560 VA: 0x181225F60 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t : MulticastDelegate // TypeDefIndex: 2494
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222ED0 Offset: 0x12214D0 VA: 0x181222ED0 Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1223390 Offset: 0x1221990 VA: 0x181223390 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t : MulticastDelegate // TypeDefIndex: 2495
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222ED0 Offset: 0x12214D0 VA: 0x181222ED0 Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1222E00 Offset: 0x1221400 VA: 0x181222E00 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate // TypeDefIndex: 2496
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223DE0 Offset: 0x12223E0 VA: 0x181223DE0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1223D50 Offset: 0x1222350 VA: 0x181223D50 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate // TypeDefIndex: 2497
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xFFA0A0 Offset: 0xFF86A0 VA: 0x180FFA0A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t : MulticastDelegate // TypeDefIndex: 2498
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xFFA0A0 Offset: 0xFF86A0 VA: 0x180FFA0A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate // TypeDefIndex: 2499
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xFFA0A0 Offset: 0xFF86A0 VA: 0x180FFA0A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate // TypeDefIndex: 2500
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12240E0 Offset: 0x12226E0 VA: 0x1812240E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1224410 Offset: 0x1222A10 VA: 0x181224410 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate // TypeDefIndex: 2501
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223460 Offset: 0x1221A60 VA: 0x181223460 Slot: 12
	public virtual UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_ciphersuite EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t : MulticastDelegate // TypeDefIndex: 2502
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223460 Offset: 0x1221A60 VA: 0x181223460 Slot: 12
	public virtual UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_protocol EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t : MulticastDelegate // TypeDefIndex: 2503
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223460 Offset: 0x1221A60 VA: 0x181223460 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t : MulticastDelegate // TypeDefIndex: 2504
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223A20 Offset: 0x1222020 VA: 0x181223A20 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1223CB0 Offset: 0x12222B0 VA: 0x181223CB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t : MulticastDelegate // TypeDefIndex: 2505
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223A20 Offset: 0x1222020 VA: 0x181223A20 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12245F0 Offset: 0x1222BF0 VA: 0x1812245F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t : MulticastDelegate // TypeDefIndex: 2506
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223690 Offset: 0x1221C90 VA: 0x181223690 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t : MulticastDelegate // TypeDefIndex: 2507
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221A70 Offset: 0x1220070 VA: 0x181221A70 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t : MulticastDelegate // TypeDefIndex: 2508
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1222550 Offset: 0x1220B50 VA: 0x181222550 Slot: 12
	public virtual void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12224C0 Offset: 0x1220AC0 VA: 0x1812224C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

