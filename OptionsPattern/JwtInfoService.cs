using Microsoft.Extensions.Options;

namespace OptionsPattern;

public interface IJwtInfoService
{
    public JwtInfo GetJwtInfo();
}
public class JwtInfoService : IJwtInfoService
{
    private readonly IOptions<JwtInfo> _jwtInfo;

    public JwtInfoService(IOptions<JwtInfo> jwtInfo)
    {
        _jwtInfo = jwtInfo;
    }

    public JwtInfo GetJwtInfo()
    {
        return _jwtInfo.Value;
    }
}