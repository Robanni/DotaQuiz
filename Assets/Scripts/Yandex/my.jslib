mergeInto(LibraryManager.library,{

    
    ShowRespawnAdv: function(){
    	ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          myGameInstance.SendMessage("Main Camera","GetRespawn")
        },
        onClose: () => {
          console.log('Video ad closed.');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
})
    },
    ShowDeathAdv: function(){
    	ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          myGameInstance.SendMessage("GameController","EnableMusic");
        },
        onError: function(error) {
          myGameInstance.SendMessage("GameController","EnableMusic");
        }
    }
})
    }
});