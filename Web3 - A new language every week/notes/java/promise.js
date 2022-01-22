let myPromise = new Promise(function(resolve,reject){
    setTimeout(()=>resolve(3),3000);
});

myPromise.then((resolvedData)=>{
    console.log(resolvedData);
});