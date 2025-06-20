using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimelineManager : MonoBehaviour
{
    public PlayableDirector director;         // Assign your character's PlayableDirector
    public PlayableAsset[] timelines;         // Assign Timeline1 to Timeline4 here
    public Button nextButton;
    public Button replayButton;
    public Button nextSceneButton;

    private int currentIndex = 0;

    void Start()
    {
        nextButton.onClick.AddListener(PlayNext);
        replayButton.onClick.AddListener(ReplayCurrent);
        nextSceneButton.onClick.AddListener(LoadNextScene);

        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
        nextSceneButton.gameObject.SetActive(false);

        PlayTimeline(currentIndex);
    }

    void PlayTimeline(int index)
    {
        if (index >= 0 && index < timelines.Length)
        {
            director.playableAsset = timelines[index];
            director.Play();
            director.stopped += OnTimelineStopped;
        }
    }

    void OnTimelineStopped(PlayableDirector pd)
    {
        replayButton.gameObject.SetActive(true);

        if (currentIndex < timelines.Length - 1)
            nextButton.gameObject.SetActive(true);
        else
            nextSceneButton.gameObject.SetActive(true);

        pd.stopped -= OnTimelineStopped;
    }

    void PlayNext()
    {
        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);

        currentIndex++;
        if (currentIndex < timelines.Length)
            PlayTimeline(currentIndex);
    }

    void ReplayCurrent()
    {
        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);

        PlayTimeline(currentIndex);
    }

    void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(3);
    }
}
