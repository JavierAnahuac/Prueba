using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOviparous
{
    public void LayEggs(int _days);
    public bool HaveEggsHatched();
    public void WhenTheEggsHatched();
}
