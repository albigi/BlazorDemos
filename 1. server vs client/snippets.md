## UI

```
<p>Refresh count</p>
<ul>
    <li>Global: @globalRefresh</li>
    <li>Local: @localRefresh</li>
</ul>

<button class="btn btn-primary" @onclick="Refresh">Refresh</button>
```

## CODE

```
private static int globalRefresh = 0;
private int localRefresh = 0;
```

```
GlobalIncrementHandler.Increment(ref globalRefresh);
localRefresh++;
```

```
GlobalIncrementHandler.OnIncrement += () =>
    {
        InvokeAsync(StateHasChanged);
    };
```

```
public class GlobalIncrementHandler
{
    public Action OnIncrement {get;set;}
    public void Increment(ref int i)
    {
        System.Threading.Interlocked.Increment(ref i);
        OnIncrement?.Invoke();
    }
}
```