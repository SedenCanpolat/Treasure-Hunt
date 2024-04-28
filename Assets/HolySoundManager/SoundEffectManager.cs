using UnityEngine;
using UnityEngine.Audio;


namespace Holylib.HolySoundEffects
{
    public static class SoundEffectController 
    {
        static SoundSource Play(AudioClip audioClip,string mixerGroup)
        {
            GameObject soundObj = new();
            soundObj.AddComponent<SoundSource>();
            soundObj.AddComponent<AudioSource>();

            var source = soundObj.GetComponent<AudioSource>();
            source.clip = audioClip;

            // set audio mixer
            AudioMixer mix = Resources.Load("General") as AudioMixer;
            source.outputAudioMixerGroup = mix.FindMatchingGroups(mixerGroup)[0];

            soundObj.GetComponent<SoundSource>().Initialize();

            return soundObj.GetComponent<SoundSource>();
        }

        public static SoundSource PlaySFX(AudioClip audioClip)
        {
            return Play(audioClip, "SFX");
        }

        public static SoundSource PlayMusic(AudioClip audioClip)
        {
            return Play(audioClip, "Music").SetLoop(true);
        }

        public static void StopSFX(SoundSource soundsource)
        {
            soundsource.StopSFX();
        }

        public static void StopSFX(GameObject soundsourceOBJ)
        {
            soundsourceOBJ.GetComponent<SoundSource>().StopSFX();
        }

        public static void StopAllSounds()
        {
            foreach(SoundSource s in Object.FindObjectsOfType<SoundSource>())
            {
                s.StopSFX();
            }    
        }

        static void SetVolume(float value,string MixerParameter)
        {
            AudioMixer mix = Resources.Load("General") as AudioMixer;
            float logval = Mathf.Log10(value + 0.00001f) * 20;
            mix.SetFloat(MixerParameter, logval);
        }
        static float GetVolume(string MixerParameter)
        {
            AudioMixer mix = Resources.Load("General") as AudioMixer;
            float val;
            mix.GetFloat(MixerParameter,out val);

            return val;
        }
        public static float MasterVolume
        {
            get
            {
                return GetVolume("MasterVolume");
            }
            set
            {
                SetVolume(value, "MasterVolume");
            }
            
        }

        public static float MusicVolume
        {
            get
            {
                return GetVolume("MusicVolume");
            }
            set
            {
                SetVolume(value, "MusicVolume");
            }

        }

        public static float SFXVolume
        {
            get
            {
                return GetVolume("SFXVolume");
            }
            set
            {
                SetVolume(value, "SFXVolume");
            }

        }

    }

    public class SoundSource : MonoBehaviour
    {
        AudioSource audioSource;

        public void Initialize()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
        private void Update()
        {
            if (audioSource.time >= audioSource.clip.length && !audioSource.loop)
            {
                // music finished;

                StopSFX();
            }
        }

        public void StopSFX()
        {
            Destroy(this.gameObject);
        }

        /// <summary>
        /// Set the pitch a random value between min and max
        /// </summary>
        public SoundSource RandomPitchRange(float min,float max)
        {
            audioSource.pitch = Random.Range(min,max);
            return this;
        }

        /// <summary>
        /// Set the pitch value
        /// </summary>
        public SoundSource SetPitch(float value)
        {
            audioSource.pitch = value;
            return this;
        }

        /// <summary>
        /// Set the volume
        /// </summary>
        public SoundSource SetVolume(float value)
        {
            audioSource.volume = value;
            return this;
        }

        public SoundSource SetDontDestroyOnLoad()
        {
            DontDestroyOnLoad(this.gameObject);
            return this;
        }

        public SoundSource SetLoop(bool value)
        {
            audioSource.loop = value;
            return this;
        }
    }
}