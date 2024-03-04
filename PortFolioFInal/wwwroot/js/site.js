// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// script.js

document.addEventListener("DOMContentLoaded", function () {
    const options = {
        strings: ['Photographer', 'teacher', 'researcher'],
        typeSpeed: 100, // typing speed in milliseconds
        backSpeed: 50, // backspacing speed in milliseconds
        backDelay: 1000, // delay before starting to backspace
        loop: true, // loop the animation
        showCursor: true, // show blinking cursor
        cursorChar: '|', // customize cursor character
    };

    const typed = new Typed('#typed-output', options);
});
function isInViewport(element) {
    const rect = element.getBoundingClientRect();
    return (
        rect.top >= 0 &&
        rect.left >= 0 &&
        rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
        rect.right <= (window.innerWidth || document.documentElement.clientWidth)
    );
}

// Function to handle the scroll event
function handleScroll() {
    const timelineItems = document.querySelectorAll('.timeline-item');

    timelineItems.forEach(item => {
        item.classList.remove('active'); // Remove active class from all items
        if (isInViewport(item)) {
            item.classList.add('active'); // Add active class to items in viewport
        }
    });
}

// Add event listener for scroll
window.addEventListener('scroll', handleScroll);

// Initial check on page load
window.addEventListener('load', handleScroll);


$(document).ready(function () {
    // Activate carousel
    $('#projectCarousel').carousel();
});
