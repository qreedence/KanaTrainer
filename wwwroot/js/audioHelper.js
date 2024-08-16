const keyboardSoundBank = [
    new Audio('/audio/keyboard/keyboard1.wav'),
/*    new Audio('/audio/keyboard/keyboard2.wav'),*/
/*    new Audio('/audio/keyboard/keyboard3.wav'),*/
/*    new Audio('/audio/keyboard/keyboard4.wav'),*/
];

const errorSoundBank = [
    new Audio('/audio/error/error1.wav'),
]

const correctSoundBank = [
/*    new Audio('/audio/correct/correct1.wav'),*/
]

function playRandomKeyboardSound() {
    const randomIndex = Math.floor(Math.random() * keyboardSoundBank.length);
    const sound = keyboardSoundBank[randomIndex];
    sound.currentTime = 0; // Reset the audio to the start
    sound.play();
}

function playRandomErrorSound() {
    const randomIndex = Math.floor(Math.random() * errorSoundBank.length);
    const sound = errorSoundBank[randomIndex];
/*    sound.currentTime = 0; // Reset the audio to the start*/
    sound.play();
}

function playRandomCorrectSound() {
    const randomIndex = Math.floor(Math.random() * correctSoundBank.length);
    const sound = correctSoundBank[randomIndex];
    sound.currentTime = 0; // Reset the audio to the start
    sound.play();
}