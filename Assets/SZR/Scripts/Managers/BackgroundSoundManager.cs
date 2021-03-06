﻿// Copyright 2015 - 2018 Jesse Freeman
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using jessefreeman.utools;
using UnityEngine;

public class BackgroundSoundManager : MonoBehaviour
{
    public RecycledSound currentTrack;

    public Sounds sound;
    public float volume = .5f;

    // Use this for initialization
    private void Start()
    {
        var soundManager = GameObjectUtil.GetSingleton<SoundManager>();

        if (soundManager != null)
        {
            currentTrack = soundManager.PlayClip((int) sound, Vector3.zero, true, volume, false, true);
            currentTrack.FadeSound(0, volume, 1f);
        }
    }

    public void FadeSound(float start, float end, float delay = 1f)
    {
        if (currentTrack != null)
            currentTrack.FadeSound(start, end, delay);
    }
}