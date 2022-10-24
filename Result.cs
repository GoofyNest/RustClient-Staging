public enum Result // TypeDefIndex: 5139
{
	public int value__; 
	public const Result None = 0;
	public const Result OK = 1;
	public const Result Fail = 2;
	public const Result NoConnection = 3;
	public const Result InvalidPassword = 5;
	public const Result LoggedInElsewhere = 6;
	public const Result InvalidProtocolVer = 7;
	public const Result InvalidParam = 8;
	public const Result FileNotFound = 9;
	public const Result Busy = 10;
	public const Result InvalidState = 11;
	public const Result InvalidName = 12;
	public const Result InvalidEmail = 13;
	public const Result DuplicateName = 14;
	public const Result AccessDenied = 15;
	public const Result Timeout = 16;
	public const Result Banned = 17;
	public const Result AccountNotFound = 18;
	public const Result InvalidSteamID = 19;
	public const Result ServiceUnavailable = 20;
	public const Result NotLoggedOn = 21;
	public const Result Pending = 22;
	public const Result EncryptionFailure = 23;
	public const Result InsufficientPrivilege = 24;
	public const Result LimitExceeded = 25;
	public const Result Revoked = 26;
	public const Result Expired = 27;
	public const Result AlreadyRedeemed = 28;
	public const Result DuplicateRequest = 29;
	public const Result AlreadyOwned = 30;
	public const Result IPNotFound = 31;
	public const Result PersistFailed = 32;
	public const Result LockingFailed = 33;
	public const Result LogonSessionReplaced = 34;
	public const Result ConnectFailed = 35;
	public const Result HandshakeFailed = 36;
	public const Result IOFailure = 37;
	public const Result RemoteDisconnect = 38;
	public const Result ShoppingCartNotFound = 39;
	public const Result Blocked = 40;
	public const Result Ignored = 41;
	public const Result NoMatch = 42;
	public const Result AccountDisabled = 43;
	public const Result ServiceReadOnly = 44;
	public const Result AccountNotFeatured = 45;
	public const Result AdministratorOK = 46;
	public const Result ContentVersion = 47;
	public const Result TryAnotherCM = 48;
	public const Result PasswordRequiredToKickSession = 49;
	public const Result AlreadyLoggedInElsewhere = 50;
	public const Result Suspended = 51;
	public const Result Cancelled = 52;
	public const Result DataCorruption = 53;
	public const Result DiskFull = 54;
	public const Result RemoteCallFailed = 55;
	public const Result PasswordUnset = 56;
	public const Result ExternalAccountUnlinked = 57;
	public const Result PSNTicketInvalid = 58;
	public const Result ExternalAccountAlreadyLinked = 59;
	public const Result RemoteFileConflict = 60;
	public const Result IllegalPassword = 61;
	public const Result SameAsPreviousValue = 62;
	public const Result AccountLogonDenied = 63;
	public const Result CannotUseOldPassword = 64;
	public const Result InvalidLoginAuthCode = 65;
	public const Result AccountLogonDeniedNoMail = 66;
	public const Result HardwareNotCapableOfIPT = 67;
	public const Result IPTInitError = 68;
	public const Result ParentalControlRestricted = 69;
	public const Result FacebookQueryError = 70;
	public const Result ExpiredLoginAuthCode = 71;
	public const Result IPLoginRestrictionFailed = 72;
	public const Result AccountLockedDown = 73;
	public const Result AccountLogonDeniedVerifiedEmailRequired = 74;
	public const Result NoMatchingURL = 75;
	public const Result BadResponse = 76;
	public const Result RequirePasswordReEntry = 77;
	public const Result ValueOutOfRange = 78;
	public const Result UnexpectedError = 79;
	public const Result Disabled = 80;
	public const Result InvalidCEGSubmission = 81;
	public const Result RestrictedDevice = 82;
	public const Result RegionLocked = 83;
	public const Result RateLimitExceeded = 84;
	public const Result AccountLoginDeniedNeedTwoFactor = 85;
	public const Result ItemDeleted = 86;
	public const Result AccountLoginDeniedThrottle = 87;
	public const Result TwoFactorCodeMismatch = 88;
	public const Result TwoFactorActivationCodeMismatch = 89;
	public const Result AccountAssociatedToMultiplePartners = 90;
	public const Result NotModified = 91;
	public const Result NoMobileDevice = 92;
	public const Result TimeNotSynced = 93;
	public const Result SmsCodeFailed = 94;
	public const Result AccountLimitExceeded = 95;
	public const Result AccountActivityLimitExceeded = 96;
	public const Result PhoneActivityLimitExceeded = 97;
	public const Result RefundToWallet = 98;
	public const Result EmailSendFailure = 99;
	public const Result NotSettled = 100;
	public const Result NeedCaptcha = 101;
	public const Result GSLTDenied = 102;
	public const Result GSOwnerDenied = 103;
	public const Result InvalidItemType = 104;
	public const Result IPBanned = 105;
	public const Result GSLTExpired = 106;
	public const Result InsufficientFunds = 107;
	public const Result TooManyPending = 108;
	public const Result NoSiteLicensesFound = 109;
	public const Result WGNetworkSendExceeded = 110;
	public const Result AccountNotFriends = 111;
	public const Result LimitedUserAccount = 112;
	public const Result CantRemoveItem = 113;
	public const Result AccountDeleted = 114;
	public const Result ExistingUserCancelledLicense = 115;
	public const Result CommunityCooldown = 116;
	public const Result NoLauncherSpecified = 117;
	public const Result MustAgreeToSSA = 118;
	public const Result LauncherMigrated = 119;
	public const Result SteamRealmMismatch = 120;
	public const Result InvalidSignature = 121;
	public const Result ParseFailure = 122;
	public const Result NoVerifiedPhone = 123;

}

public class Result.Entry<T> // TypeDefIndex: 6266
{
	public T Content; 
	public string Id; 
	public DateTime Created; 
	public DateTime Updated; 
	public string AuthorId; 
	public string AuthorName; 
	public string AuthType; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Result.Entry<object>..ctor
	*/

}

public enum Result // TypeDefIndex: 8286
{
	public int value__; 
	public const Result Success = 0;
	public const Result NoConnection = 1;
	public const Result InvalidCredentials = 2;
	public const Result InvalidUser = 3;
	public const Result InvalidAuth = 4;
	public const Result AccessDenied = 5;
	public const Result MissingPermissions = 6;
	public const Result TokenNotAccount = 7;
	public const Result TooManyRequests = 8;
	public const Result AlreadyPending = 9;
	public const Result InvalidParameters = 10;
	public const Result InvalidRequest = 11;
	public const Result UnrecognizedResponse = 12;
	public const Result IncompatibleVersion = 13;
	public const Result NotConfigured = 14;
	public const Result AlreadyConfigured = 15;
	public const Result NotImplemented = 16;
	public const Result Canceled = 17;
	public const Result NotFound = 18;
	public const Result OperationWillRetry = 19;
	public const Result NoChange = 20;
	public const Result VersionMismatch = 21;
	public const Result LimitExceeded = 22;
	public const Result Disabled = 23;
	public const Result DuplicateNotAllowed = 24;
	public const Result MissingParametersDEPRECATED = 25;
	public const Result InvalidSandboxId = 26;
	public const Result TimedOut = 27;
	public const Result PartialResult = 28;
	public const Result MissingRole = 29;
	public const Result MissingFeature = 30;
	public const Result InvalidSandbox = 31;
	public const Result InvalidDeployment = 32;
	public const Result InvalidProduct = 33;
	public const Result InvalidProductUserID = 34;
	public const Result ServiceFailure = 35;
	public const Result CacheDirectoryMissing = 36;
	public const Result CacheDirectoryInvalid = 37;
	public const Result InvalidState = 38;
	public const Result RequestInProgress = 39;
	public const Result ApplicationSuspended = 40;
	public const Result NetworkDisconnected = 41;
	public const Result AuthAccountLocked = 1001;
	public const Result AuthAccountLockedForUpdate = 1002;
	public const Result AuthInvalidRefreshToken = 1003;
	public const Result AuthInvalidToken = 1004;
	public const Result AuthAuthenticationFailure = 1005;
	public const Result AuthInvalidPlatformToken = 1006;
	public const Result AuthWrongAccount = 1007;
	public const Result AuthWrongClient = 1008;
	public const Result AuthFullAccountRequired = 1009;
	public const Result AuthHeadlessAccountRequired = 1010;
	public const Result AuthPasswordResetRequired = 1011;
	public const Result AuthPasswordCannotBeReused = 1012;
	public const Result AuthExpired = 1013;
	public const Result AuthScopeConsentRequired = 1014;
	public const Result AuthApplicationNotFound = 1015;
	public const Result AuthScopeNotFound = 1016;
	public const Result AuthAccountFeatureRestricted = 1017;
	public const Result AuthAccountPortalLoadError = 1018;
	public const Result AuthCorrectiveActionRequired = 1019;
	public const Result AuthPinGrantCode = 1020;
	public const Result AuthPinGrantExpired = 1021;
	public const Result AuthPinGrantPending = 1022;
	public const Result AuthExternalAuthNotLinked = 1030;
	public const Result AuthExternalAuthRevoked = 1032;
	public const Result AuthExternalAuthInvalid = 1033;
	public const Result AuthExternalAuthRestricted = 1034;
	public const Result AuthExternalAuthCannotLogin = 1035;
	public const Result AuthExternalAuthExpired = 1036;
	public const Result AuthExternalAuthIsLastLoginType = 1037;
	public const Result AuthExchangeCodeNotFound = 1040;
	public const Result AuthOriginatingExchangeCodeSessionExpired = 1041;
	public const Result AuthAccountNotActive = 1050;
	public const Result AuthMFARequired = 1060;
	public const Result AuthParentalControls = 1070;
	public const Result AuthNoRealId = 1080;
	public const Result FriendsInviteAwaitingAcceptance = 2000;
	public const Result FriendsNoInvitation = 2001;
	public const Result FriendsAlreadyFriends = 2003;
	public const Result FriendsNotFriends = 2004;
	public const Result FriendsTargetUserTooManyInvites = 2005;
	public const Result FriendsLocalUserTooManyInvites = 2006;
	public const Result FriendsTargetUserFriendLimitExceeded = 2007;
	public const Result FriendsLocalUserFriendLimitExceeded = 2008;
	public const Result PresenceDataInvalid = 3000;
	public const Result PresenceDataLengthInvalid = 3001;
	public const Result PresenceDataKeyInvalid = 3002;
	public const Result PresenceDataKeyLengthInvalid = 3003;
	public const Result PresenceDataValueInvalid = 3004;
	public const Result PresenceDataValueLengthInvalid = 3005;
	public const Result PresenceRichTextInvalid = 3006;
	public const Result PresenceRichTextLengthInvalid = 3007;
	public const Result PresenceStatusInvalid = 3008;
	public const Result EcomEntitlementStale = 4000;
	public const Result EcomCatalogOfferStale = 4001;
	public const Result EcomCatalogItemStale = 4002;
	public const Result EcomCatalogOfferPriceInvalid = 4003;
	public const Result EcomCheckoutLoadError = 4004;
	public const Result SessionsSessionInProgress = 5000;
	public const Result SessionsTooManyPlayers = 5001;
	public const Result SessionsNoPermission = 5002;
	public const Result SessionsSessionAlreadyExists = 5003;
	public const Result SessionsInvalidLock = 5004;
	public const Result SessionsInvalidSession = 5005;
	public const Result SessionsSandboxNotAllowed = 5006;
	public const Result SessionsInviteFailed = 5007;
	public const Result SessionsInviteNotFound = 5008;
	public const Result SessionsUpsertNotAllowed = 5009;
	public const Result SessionsAggregationFailed = 5010;
	public const Result SessionsHostAtCapacity = 5011;
	public const Result SessionsSandboxAtCapacity = 5012;
	public const Result SessionsSessionNotAnonymous = 5013;
	public const Result SessionsOutOfSync = 5014;
	public const Result SessionsTooManyInvites = 5015;
	public const Result SessionsPresenceSessionExists = 5016;
	public const Result SessionsDeploymentAtCapacity = 5017;
	public const Result SessionsNotAllowed = 5018;
	public const Result SessionsPlayerSanctioned = 5019;
	public const Result PlayerDataStorageFilenameInvalid = 6000;
	public const Result PlayerDataStorageFilenameLengthInvalid = 6001;
	public const Result PlayerDataStorageFilenameInvalidChars = 6002;
	public const Result PlayerDataStorageFileSizeTooLarge = 6003;
	public const Result PlayerDataStorageFileSizeInvalid = 6004;
	public const Result PlayerDataStorageFileHandleInvalid = 6005;
	public const Result PlayerDataStorageDataInvalid = 6006;
	public const Result PlayerDataStorageDataLengthInvalid = 6007;
	public const Result PlayerDataStorageStartIndexInvalid = 6008;
	public const Result PlayerDataStorageRequestInProgress = 6009;
	public const Result PlayerDataStorageUserThrottled = 6010;
	public const Result PlayerDataStorageEncryptionKeyNotSet = 6011;
	public const Result PlayerDataStorageUserErrorFromDataCallback = 6012;
	public const Result PlayerDataStorageFileHeaderHasNewerVersion = 6013;
	public const Result PlayerDataStorageFileCorrupted = 6014;
	public const Result ConnectExternalTokenValidationFailed = 7000;
	public const Result ConnectUserAlreadyExists = 7001;
	public const Result ConnectAuthExpired = 7002;
	public const Result ConnectInvalidToken = 7003;
	public const Result ConnectUnsupportedTokenType = 7004;
	public const Result ConnectLinkAccountFailed = 7005;
	public const Result ConnectExternalServiceUnavailable = 7006;
	public const Result ConnectExternalServiceConfigurationFailure = 7007;
	public const Result ConnectLinkAccountFailedMissingNintendoIdAccountDEPRECATED = 7008;
	public const Result SocialOverlayLoadError = 8000;
	public const Result LobbyNotOwner = 9000;
	public const Result LobbyInvalidLock = 9001;
	public const Result LobbyLobbyAlreadyExists = 9002;
	public const Result LobbySessionInProgress = 9003;
	public const Result LobbyTooManyPlayers = 9004;
	public const Result LobbyNoPermission = 9005;
	public const Result LobbyInvalidSession = 9006;
	public const Result LobbySandboxNotAllowed = 9007;
	public const Result LobbyInviteFailed = 9008;
	public const Result LobbyInviteNotFound = 9009;
	public const Result LobbyUpsertNotAllowed = 9010;
	public const Result LobbyAggregationFailed = 9011;
	public const Result LobbyHostAtCapacity = 9012;
	public const Result LobbySandboxAtCapacity = 9013;
	public const Result LobbyTooManyInvites = 9014;
	public const Result LobbyDeploymentAtCapacity = 9015;
	public const Result LobbyNotAllowed = 9016;
	public const Result LobbyMemberUpdateOnly = 9017;
	public const Result LobbyPresenceLobbyExists = 9018;
	public const Result LobbyVoiceNotEnabled = 9019;
	public const Result TitleStorageUserErrorFromDataCallback = 10000;
	public const Result TitleStorageEncryptionKeyNotSet = 10001;
	public const Result TitleStorageFileCorrupted = 10002;
	public const Result TitleStorageFileHeaderHasNewerVersion = 10003;
	public const Result ModsModSdkProcessIsAlreadyRunning = 11000;
	public const Result ModsModSdkCommandIsEmpty = 11001;
	public const Result ModsModSdkProcessCreationFailed = 11002;
	public const Result ModsCriticalError = 11003;
	public const Result ModsToolInternalError = 11004;
	public const Result ModsIPCFailure = 11005;
	public const Result ModsInvalidIPCResponse = 11006;
	public const Result ModsURILaunchFailure = 11007;
	public const Result ModsModIsNotInstalled = 11008;
	public const Result ModsUserDoesNotOwnTheGame = 11009;
	public const Result ModsOfferRequestByIdInvalidResult = 11010;
	public const Result ModsCouldNotFindOffer = 11011;
	public const Result ModsOfferRequestByIdFailure = 11012;
	public const Result ModsPurchaseFailure = 11013;
	public const Result ModsInvalidGameInstallInfo = 11014;
	public const Result ModsCannotGetManifestLocation = 11015;
	public const Result ModsUnsupportedOS = 11016;
	public const Result AntiCheatClientProtectionNotAvailable = 12000;
	public const Result AntiCheatInvalidMode = 12001;
	public const Result AntiCheatClientProductIdMismatch = 12002;
	public const Result AntiCheatClientSandboxIdMismatch = 12003;
	public const Result AntiCheatProtectMessageSessionKeyRequired = 12004;
	public const Result AntiCheatProtectMessageValidationFailed = 12005;
	public const Result AntiCheatProtectMessageInitializationFailed = 12006;
	public const Result AntiCheatPeerAlreadyRegistered = 12007;
	public const Result AntiCheatPeerNotFound = 12008;
	public const Result AntiCheatPeerNotProtected = 12009;
	public const Result AntiCheatClientDeploymentIdMismatch = 12010;
	public const Result AntiCheatDeviceIdAuthIsNotSupported = 12011;
	public const Result TooManyParticipants = 13000;
	public const Result RoomAlreadyExists = 13001;
	public const Result UserKicked = 13002;
	public const Result UserBanned = 13003;
	public const Result RoomWasLeft = 13004;
	public const Result ReconnectionTimegateExpired = 13005;
	public const Result ShutdownInvoked = 13006;
	public const Result UserIsInBlocklist = 13007;
	public const Result ProgressionSnapshotSnapshotIdUnavailable = 14000;
	public const Result ParentEmailMissing = 15000;
	public const Result UserGraduated = 15001;
	public const Result AndroidJavaVMNotStored = 17000;
	public const Result PermissionRequiredPatchAvailable = 18000;
	public const Result PermissionRequiredSystemUpdate = 18001;
	public const Result PermissionAgeRestrictionFailure = 18002;
	public const Result PermissionAccountTypeFailure = 18003;
	public const Result PermissionChatRestriction = 18004;
	public const Result PermissionUGCRestriction = 18005;
	public const Result PermissionOnlinePlayRestricted = 18006;
	public const Result DesktopCrossplayApplicationNotBootstrapped = 19000;
	public const Result DesktopCrossplayServiceNotInstalled = 19001;
	public const Result DesktopCrossplayServiceStartFailed = 19002;
	public const Result DesktopCrossplayServiceNotRunning = 19003;
	public const Result UnexpectedError = 2147483647;

}

