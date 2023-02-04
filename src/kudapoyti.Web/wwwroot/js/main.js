//(function ($) {
//    "use strict";

//    // Dropdown on mouse hover
//    $(document).ready(function () {
//        function toggleNavbarMethod() {
//            if ($(window).width() > 992) {
//                $('.navbar .dropdown').on('mouseover', function () {
//                    $('.dropdown-toggle', this).trigger('click');
//                }).on('mouseout', function () {
//                    $('.dropdown-toggle', this).trigger('click').blur();
//                });
//            } else {
//                $('.navbar .dropdown').off('mouseover').off('mouseout');
//            }
//        }
//        toggleNavbarMethod();
//        $(window).resize(toggleNavbarMethod);
//    });


//    // Back to top button
//    $(window).scroll(function () {
//            if ($(this).scrollTop() > 100) {
//                $('.back-to-top').fadeIn('slow');
//            } else {
//                    $('.back-to-top').fadeOut('slow');
//                }
//            });
//                $('.back-to-top').click(function () {
//                    $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
//                    return false;
//                });


//                // Date and time picker
//                $('.date').datetimepicker({
//                    format: 'L'
//                });
//                $('.time').datetimepicker({
//                    format: 'LT'
//                });


//                // Testimonials carousel
//                $(".testimonial-carousel").owlCarousel({
//                    autoplay: true,
//                    smartSpeed: 1500,
//                    margin: 30,
//                    dots: true,
//                    loop: true,
//                    center: true,
//                    responsive: {
//                        0: {
//                            items: 1
//                        },
//                        576: {
//                            items: 1
//                        },
//                        768: {
//                            items: 2
//                        },
//                        992: {
//                            items: 3
//                        }
//                    }
//                });


//            })(jQuery);
//let commentBtn = document.getElementById("commentBtn");
//let formBlock = document.getElementById("formBlock");

//async function hueta() {
//    const response = await fetch("https://qweqweqwe", {

//    });
//    const data = await response.json();
//    return data;
//}

//formBlock.addEventListener("submit", (evt) => {
//    evt.preventDefault();


//})
$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    $('button[data-toggle="ajax - modal" ]').click (function (event) {

        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })


    PlaceHolderElement.on(' click ', ' [data- save="modal"]', function (event) {

        var form = $(this).parents(' .modal').find('form');
        var actionUrl = form.attr('action');
        var url = "/employeess/" + actionUrl;
        var sendData = form.serialize();
        $.post(url, sendData).done(function (data) {
            PlaceHolderElement.find(' .modal').modal('hide');

        })
    })
}