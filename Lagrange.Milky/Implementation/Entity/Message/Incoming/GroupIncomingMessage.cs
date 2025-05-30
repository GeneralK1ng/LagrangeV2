using System.Text.Json.Serialization;

namespace Lagrange.Milky.Implementation.Entity.Message.Incoming;

public class GroupIncomingMessage() : IncomingMessageBase("group")
{
    [JsonPropertyName("group")]
    public required Group Group { get; init; }

    [JsonPropertyName("group_member")]
    public required GroupMember GroupMember { get; init; }
}