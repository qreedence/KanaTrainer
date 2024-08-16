function triggerPreviousAnimation() {
    const previousElement = document.querySelector('.previous');
    if (previousElement) {
        previousElement.classList.remove('animate'); // Remove class to restart animation
        void previousElement.offsetWidth; // Trigger reflow to restart animation
        previousElement.classList.add('animate'); // Add class to start animation
    }
}

window.triggerPreviousAnimation = triggerPreviousAnimation;

function triggerShakeAnimation() {
    const trainerGameElement = document.querySelector('.trainer-game');
    trainerGameElement.classList.remove('shake');
    void trainerGameElement.offsetWidth;
    trainerGameElement.classList.add('shake');
}

window.triggerShakeAnimation = triggerShakeAnimation;