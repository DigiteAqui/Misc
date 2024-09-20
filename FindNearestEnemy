public GameObject FindNearestEnemy()
{
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    
    if (enemies.Length == 0)
    {
        return null;
    }

    GameObject nearestEnemy = null;
    float shortestDistance = Mathf.Infinity;
    Vector3 currentPosition = transform.position;

    foreach (GameObject currentenemy in enemies)
    {
        float distanceToEnemy = Vector3.Distance(currentPosition, currentenemy.transform.position);

        if (distanceToEnemy < shortestDistance)
        {
            shortestDistance = distanceToEnemy;
            nearestEnemy = currentenemy.gameObject;
        }
    }

    Debug.DrawLine(this.transform.position, nearestEnemy.transform.position);
    return nearestEnemy;
}
