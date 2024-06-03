using Oculus.Interaction.Grab;
using UnityEngine;

namespace Oculus.Interaction.Samples
{
    public class SlingshotPellet : MonoBehaviour
    {
        [SerializeField]
        private PhysicsGrabbable _physicsGrabbable;
        [SerializeField]
        private Grabbable grabbable;

        [SerializeField]
        private GrabInteractable[] _GrabInteractables;

        private GrabInteractor _lastGrabInteractor;

        public GrabInteractor Grabber => _lastGrabInteractor;

        private UniqueIdentifier Identifier = UniqueIdentifier.Generate();

        private void OnEnable()
        {
            foreach (var GrabInteractable in _GrabInteractables)
            {
                GrabInteractable.WhenSelectingInteractorAdded.Action += leSelectingGrabInteractorAdded;
            }
        }

        private void OnDisable()
        {
            foreach (var GrabInteractable in _GrabInteractables)
            {
                GrabInteractable.WhenSelectingInteractorAdded.Action -= leSelectingGrabInteractorAdded;
            }
        }

        private void leSelectingGrabInteractorAdded(GrabInteractor interactor)
        {
            _lastGrabInteractor = interactor;
        }

        public void Attach()
        {
            Pose selfPose = this.transform.GetPose();
            grabbable.ProcessPointerEvent(new PointerEvent(Identifier.ID, PointerEventType.Hover, selfPose));
            grabbable.ProcessPointerEvent(new PointerEvent(Identifier.ID, PointerEventType.Select, selfPose));
            grabbable.ProcessPointerEvent(new PointerEvent(Identifier.ID, PointerEventType.Move, selfPose));
        }


        public void Move(Transform transform)
        {
            grabbable.ProcessPointerEvent(new PointerEvent(Identifier.ID, PointerEventType.Move, transform.GetPose()));
        }

        public void Eject(Vector3 force)
        {
            grabbable.ProcessPointerEvent(new PointerEvent(Identifier.ID, PointerEventType.Cancel, this.transform.GetPose()));

            _physicsGrabbable.ApplyVelocities(force, Vector3.zero);
        }

    }
}
