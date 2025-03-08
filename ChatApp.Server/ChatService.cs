using ChatApp.Shared.Services;
using MagicOnion;
using MagicOnion.Server;
using MessagePack;
using Microsoft.Extensions.Logging;

namespace ChatApp.Server;

public class ChatService : ServiceBase<IChatService>, IChatService
{
    private readonly ILogger logger;

    public ChatService(ILogger<ChatService> logger)
    {
        this.logger = logger;
    }

    // 예외를 발생시키면 클라이언트로 예외가 전달 된다.
    public UnaryResult GenerateException(string message)
    {
        throw new System.NotImplementedException();
    }

    public UnaryResult<string> SendReportAsync(string message)
    {
        logger.LogDebug($"{message}");
        return UnaryResult.FromResult(message);
    }
}
