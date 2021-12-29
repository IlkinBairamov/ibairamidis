$(document).ready(function(){
    $(window).scroll(function(){
        let height=$(window).scrollTop()
        if(height>200) {
            $(".arrow").addClass("active")
        }
        else{
            $(".arrow").removeClass("active")
        }
    })
    $(".arrow").click(function(){
        $(window).scrollTop(0)
    })
})