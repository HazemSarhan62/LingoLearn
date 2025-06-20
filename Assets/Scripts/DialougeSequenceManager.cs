using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueSequenceManager : MonoBehaviour
{
    public PlayableDirector[] timelines;
    public Button nextButton;
    public Button replayButton;
    public Button nextSceneButton;
    public string nextSceneName = "NextScene"; // Name of the next scene to load

    private int currentIndex = 0;

    void Start()
    {
        nextButton.onClick.AddListener(OnNextClicked);
        replayButton.onClick.AddListener(OnReplayClicked);
        nextSceneButton.onClick.AddListener(OnNextSceneClicked);

        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
        nextSceneButton.gameObject.SetActive(false);

        PlayCurrentTimeline();
    }

    void PlayCurrentTimeline()
    {
        if (currentIndex < timelines.Length)
        {
            timelines[currentIndex].Play();
            timelines[currentIndex].stopped += OnTimelineStopped;
        }
    }

    void OnTimelineStopped(PlayableDirector pd)
    {
        nextButton.gameObject.SetActive(true);
        replayButton.gameObject.SetActive(true);
        pd.stopped -= OnTimelineStopped;

        if (currentIndex == timelines.Length - 1)
        {
            // Last timeline finished, show scene transition button
            nextSceneButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false); // Optionally hide next button
        }
    }

    void OnNextClicked()
    {
        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);

        currentIndex++;
        if (currentIndex < timelines.Length)
        {
            PlayCurrentTimeline();
        }
    }

    void OnReplayClicked()
    {
        timelines[currentIndex].Stop();
        timelines[currentIndex].time = 0;
        timelines[currentIndex].Play();

        nextButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);

        timelines[currentIndex].stopped += OnTimelineStopped;
    }

    void OnNextSceneClicked()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Optional: Check if next index exists
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("No more scenes in build settings!");
        }
    }
}
