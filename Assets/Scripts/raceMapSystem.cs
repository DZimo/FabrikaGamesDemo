using UnityEngine;
using UnityEngine.UI;

public class raceMapSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject finalPosition, gameCarPosition;
    [SerializeField]
    private Slider sliderRaceMap;
    private float positionDifferenceFirst, positionPercentage;

    private void Start()
    {
        positionDifferenceFirst = finalPosition.transform.position.x - gameCarPosition.transform.position.x;
    }
    void Update()
    {
        calculatePositionClamp();
    }

    private void calculatePositionClamp()
    {
        positionPercentage = gameCarPosition.transform.position.x / positionDifferenceFirst;
        //updateRaceMapPosition(Mathf.Clamp(positionDifference, 0f, positionDifferenceFirst));

        updateRaceMapPosition(positionPercentage);
    }

    private void updateRaceMapPosition(float positionDifferenceClamped)
    {
        sliderRaceMap.value = positionDifferenceClamped;
    }
}
