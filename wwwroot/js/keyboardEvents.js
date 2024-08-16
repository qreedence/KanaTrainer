window.addKeyboardListener = (dotnetHelper) => {
    const handleKeyDown = (event) => {
        const key = event.key;

        // Only proceed if the key is a letter
        if (/^[a-zA-Z]$/.test(key)) {
            dotnetHelper.invokeMethodAsync('HandleKeyDown', key);
        }
    };

    // Save the handleKeyDown reference globally
    window._blazorHandleKeyDown = handleKeyDown;

    window.addEventListener('keydown', handleKeyDown);

    // Save the reference to the helper globally
    window._blazorKeyboardHelper = dotnetHelper;
};

window.removeKeyboardListener = () => {
    const handleKeyDown = window._blazorHandleKeyDown;
    if (handleKeyDown) {
        window.removeEventListener('keydown', handleKeyDown);

        // Clean up the global references
        window._blazorHandleKeyDown = null;
        window._blazorKeyboardHelper = null;
    }
};