using OrchardCore.Deployment;

namespace OrchardCore.Contents.Deployment
{
    /// <summary>
    /// Adds selected content items to a <see cref="DeploymentPlanResult"/>.
    /// </summary>
    public class ClickToDeployContentDeploymentStep : DeploymentStep
    {
        public ClickToDeployContentDeploymentStep()
        {
            Name = nameof(ClickToDeployContentDeploymentStep);
        }
    }
}
