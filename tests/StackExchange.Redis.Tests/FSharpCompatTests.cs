﻿using Xunit;

namespace StackExchange.Redis.Tests;

public class FSharpCompatTests(ITestOutputHelper output) : TestBase(output)
{
#pragma warning disable SA1129 // Do not use default value type constructor
    [Fact]
    public void RedisKeyConstructor()
    {
        Assert.Equal(default, new RedisKey());
        Assert.Equal((RedisKey)"MyKey", new RedisKey("MyKey"));
        Assert.Equal((RedisKey)"MyKey2", new RedisKey(null, "MyKey2"));
    }

    [Fact]
    public void RedisValueConstructor()
    {
        Assert.Equal(default, new RedisValue());
        Assert.Equal((RedisValue)"MyKey", new RedisValue("MyKey"));
        Assert.Equal((RedisValue)"MyKey2", new RedisValue("MyKey2", 0));
    }
#pragma warning restore SA1129 // Do not use default value type constructor
}
