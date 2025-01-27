using UnityEngine;

namespace TMUtils
{
    public static class TMRandom
    {
        public static void PlayRandomClipFromArray(AudioClip[] audioClipArray, AudioSource audioSource, float volume = 1.0f)
        {
            if (audioClipArray.Length > 0)
            {
                AudioClip randomSound = audioClipArray[Random.Range(0, audioClipArray.Length)];
                audioSource.PlayOneShot(randomSound, volume);
            }
            else
            {
                Debug.LogWarning("AudioClipArray is empty cannot play a random audio clip on audio source attached to: " + audioSource.transform.name);
            }
        }

    }
}