**To Run:**

* Run storage Emulator Locally
* Create a queue called "queue"
* Queue the following message:
```
{
    "$type": "Core.Derived, Core",
    "Foo": "a",
    "Bar": "b"
}
```

**Expected:** Webjob & Function can both deserialize the message

**Actual:** Webjob works correctly, Function throws exception

The function works if you put a full type, but this shouldn't matter since the TypeNameAssemblyFormat is set to simple. Working Functions message:

```
{
    "$type": "Core.Derived, Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Foo": "a",
    "Bar": "b"
}
```
