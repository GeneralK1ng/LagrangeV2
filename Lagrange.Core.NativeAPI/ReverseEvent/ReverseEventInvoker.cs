using Lagrange.Core.NativeAPI.ReverseEvent.Abstract;

namespace Lagrange.Core.NativeAPI.ReverseEvent
{
    public class ReverseEventInvoker
    {
        public ReverseEventInvoker(BotContext context)
        {
            BotCaptchaEvent.RegisterEventHandler(context);
            BotLoginEvent.RegisterEventHandler(context);
            BotLogEvent.RegisterEventHandler(context);
            BotMessageEvent.RegisterEventHandler(context);
            BotNewDeviceVerifyEvent.RegisterEventHandler(context);
            BotOnlineEvent.RegisterEventHandler(context);
            BotQrCodeEvent.RegisterEventHandler(context);
            BotQrCodeQueryEvent.RegisterEventHandler(context);
            BotRefreshKeystoreEvent.RegisterEventHandler(context);
        }
        
        public BotCaptchaReverseEvent BotCaptchaEvent { get; } = new();
        
        public BotLoginReverseEvent BotLoginEvent { get; } = new();
        
        public BotLogReverseEvent BotLogEvent { get; } = new();
        
        public BotMessageReverseEvent BotMessageEvent { get; } = new();
        
        public BotNewDeviceVerifyReverseEvent BotNewDeviceVerifyEvent { get; } = new();
        
        public BotOnlineReverseEvent BotOnlineEvent { get; } = new();
        
        public BotQrCodeReverseEvent BotQrCodeEvent { get; } = new();
        
        public BotQrCodeQueryReverseEvent BotQrCodeQueryEvent { get; } = new();
        
        public BotRefreshKeystoreReverseEvent BotRefreshKeystoreEvent { get; } = new();
        
        public BotSMSReverseEvent BotSMSEvent { get; } = new();
    }
}