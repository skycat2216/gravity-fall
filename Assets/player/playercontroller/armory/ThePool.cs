using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ThePool 
{
    // Start is called before the first frame update
    public class Pool : MemoryPool<ThePool>
    {
        
    }
}
